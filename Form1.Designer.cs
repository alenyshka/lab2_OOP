namespace Nasledovanie_Polimorfizm_lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.rectangle = new System.Windows.Forms.ToolStripButton();
            this.square = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.circle = new System.Windows.Forms.ToolStripButton();
            this.triangle = new System.Windows.Forms.ToolStripButton();
            this.rhombus = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new Nasledovanie_Polimorfizm_lab1.Panel1();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.line,
            this.rectangle,
            this.square,
            this.ellipse,
            this.circle,
            this.triangle,
            this.rhombus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(23, 22);
            this.line.Text = "line";
            // 
            // rectangle
            // 
            this.rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(23, 22);
            this.rectangle.Text = "rectangle";
            // 
            // square
            // 
            this.square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.square.Image = ((System.Drawing.Image)(resources.GetObject("square.Image")));
            this.square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(23, 22);
            this.square.Text = "square";
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(23, 22);
            this.ellipse.Text = "ellipse";
            // 
            // circle
            // 
            this.circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(23, 22);
            this.circle.Text = "circle";
            // 
            // triangle
            // 
            this.triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(23, 22);
            this.triangle.Text = "triangle";
            // 
            // rhombus
            // 
            this.rhombus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rhombus.Image = ((System.Drawing.Image)(resources.GetObject("rhombus.Image")));
            this.rhombus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rhombus.Name = "rhombus";
            this.rhombus.Size = new System.Drawing.Size(23, 22);
            this.rhombus.Text = "rhombus";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton line;
        private System.Windows.Forms.ToolStripButton rectangle;
        private System.Windows.Forms.ToolStripButton square;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.ToolStripButton circle;
        private System.Windows.Forms.ToolStripButton triangle;
        private System.Windows.Forms.ToolStripButton rhombus;
        private Panel1 panel1;

    }
}

