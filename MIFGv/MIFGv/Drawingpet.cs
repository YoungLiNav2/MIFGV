using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MIFGv
{
    public partial class Drawingpet : Form
    {
        public Drawingpet()
        {
            InitializeComponent();
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            Point[] points = new Point[100];
            byte[] byts = new byte[100];
            for(int i  =0; i < 100; i++)
            {         
                points[i].X = i;
                points[i].Y = i*2;
                byts[i] = 0;
            }
            GraphicsPath fPath = new GraphicsPath(points, byts);
            Graphics fGraphics = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue,3);
            fGraphics.DrawLines(bluePen, points);            
         }
    }
}
