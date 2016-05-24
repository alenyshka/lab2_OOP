using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nasledovanie_Polimorfizm_lab1.Drawers;
using Nasledovanie_Polimorfizm_lab1.Shapes;
using System.Windows;


namespace Nasledovanie_Polimorfizm_lab1
{
    public partial class Form1 : Form
    {
        MouseArgs mouseArgs = new MouseArgs();
        bool mouseDown;
        Bitmap snapshot;
        Bitmap tempDraw;
        string selectedTool;

        public Form1()
        {
            InitializeComponent();
            snapshot = new Bitmap(panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);

        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            snapshot = (Bitmap)tempDraw.Clone();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseArgs.point1 = e.Location;

            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseArgs.point2 = e.Location;
                panel1.Invalidate();
                panel1.Update();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton btn in toolStrip1.Items)
            {
                btn.Checked = false;
            }
            ToolStripButton btnClicked = e.ClickedItem as ToolStripButton;
            btnClicked.Checked = true;
            selectedTool = btnClicked.Name;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            if (tempDraw != null)
            {
                tempDraw = (Bitmap)snapshot.Clone();
                Graphics g = Graphics.FromImage(tempDraw);

                var factoryDrawer = new Drawers.Factory.Factory();
                var factoryFigure = new Shapes.Factory.Factory();

                Func<Drawer> factoryMehodDrawer = null;

                if (factoryDrawer.collection.TryGetValue(selectedTool, out factoryMehodDrawer))
                {
                    Drawer drawer = factoryMehodDrawer();

                    Func<MouseArgs, Shape> factoryMethodFigure = null;
                    if (factoryFigure.collection.TryGetValue(selectedTool, out factoryMethodFigure))
                    {
                        Shape figure = factoryMethodFigure(mouseArgs);
                        drawer.Draw(g, figure);
                    }
                }
                e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                g.Dispose();
            }
        } 
    }
}

