using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geometric_figures.Class_geometric_figures
{
    class Class_curve : Class_grafig
    {
        public Class_curve() {
            points = new Point[3];
            points[0] = new Point(30, 50);
            points[1] = new Point(100, 50);
            points[2] = new Point(150, 80);
        }

        public Class_curve(Point[] points)
        {
            this.points = points;
        }
        public override void Print_grfig(PictureBox pictureBox)
        {
            pictureBox.Refresh();
            figures = pictureBox.CreateGraphics(); 
            figures.DrawCurve(pen, points);
        }
    }
}
