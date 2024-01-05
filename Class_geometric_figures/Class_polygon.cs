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
        public Class_polygon() : base()
        {            
            points = new Point[5];
            points[0] = new Point(50, 50);
            points[1] = new Point(100, 100);
            points[2] = new Point(50, 150);
            points[3] = new Point(200, 100);
            points[4] = new Point(100, 170);
        }
        public Class_polygon(Point[] points) : base()
        {            
            this.points = points;
        }
        public override void print_grfig(PictureBox pictureBox) 
        {            
            pictureBox.Refresh();
            figures = pictureBox.CreateGraphics();
            figures.DrawPolygon(pen, points);
        }

        
    }
}
