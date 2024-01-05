using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geometric_figures.Class_geometric_figures
{
    public abstract class Class_grafig
    {
        public Graphics figures { get; set; }
        public Point[] points { get; set; }        
        public Pen pen { get; set; } = new Pen(Color.Black);
        public Class_grafig() { }

        public abstract void Print_grfig(PictureBox pictureBox);

    }
}
