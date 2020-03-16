using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Line
{
    public partial class Form1 : Form
    {
        Panel panel; 
        public Form1()
        {
            InitializeComponent();

            panel = new Panel();
            panel.Location = new Point(90, 150);
            panel.Size = new Size(200, 100);
            panel.Click += new EventHandler(this.panel_Click);
            this.Controls.Add(this.panel);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Point point = panel.PointToClient(Cursor.Position);
            MessageBox.Show(point.ToString());
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            labelXandY.Text = e.X + ", " + e.Y; 
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(e.X, e.Y, 10, 10));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Graphics graphics = this.CreateGraphics();

            graphics.DrawEllipse(Pens.Red, e.X, e.Y, 50, 50);

        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.DrawLine(Pens.Red, new Point(100, 100), new Point(400, 100)); // Horizontal line
            graphics.DrawLine(Pens.Blue, new Point(100, 100), new Point(100, 400)); // Horizontal line
            graphics.DrawLine(Pens.DarkGreen, new Point(400, 100), new Point(100, 400)); // Horizontal line


            // Drawing Circle 
            graphics.DrawEllipse(Pens.Red, 200, 200, 100, 100); 
        }
    }
}
