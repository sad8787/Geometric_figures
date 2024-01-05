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
        public Class_curve() : base()
        {            
            points = new Point[3];
            points[0] = new Point(50, 80);
            points[1] = new Point(150, 150);
            points[2] = new Point(200, 100);
        }

        public Class_curve(Point[] points) : base()
        {            
            this.points = points;
        }
        public override void print_grfig(PictureBox pictureBox)
        {
            pictureBox.Refresh();
            figures = pictureBox.CreateGraphics(); 
            figures.DrawCurve(pen, points);
        }
    }
}
