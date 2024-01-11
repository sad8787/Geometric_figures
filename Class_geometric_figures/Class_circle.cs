using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometric_figures.Class_geometric_figures
{
    class Class_circle : Class_grafig
    {
        public Class_circle() : base()   
        {            
        }
        public override void print_grfig(PictureBox pictureBox)
        {           
            pictureBox.Refresh();
            figures = pictureBox.CreateGraphics();
            figures.DrawEllipse(pen, 10, 10, 50, 50);
            
        }
    }
}
