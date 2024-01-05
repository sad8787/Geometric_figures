using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geometric_figures.Class_geometric_figures
{
    class Class_polygon : Class_grafig
    {
        public Class_polygon() {
            points = new Point[5];
            points[0] = new Point(30, 50);
            points[1] = new Point(60, 50);
            points[2] = new Point(80, 80);
            points[3] = new Point(100, 90);
            points[4] = new Point(120 , 100);
        }
        public Class_polygon(Point[] points)
        {
            this.points = points;
        }
        public override void Print_grfig(PictureBox pictureBox) 
        {
            pictureBox.Refresh();
            figures = pictureBox.CreateGraphics();
            figures.DrawPolygon(pen, points);
        }

        
    }
}
