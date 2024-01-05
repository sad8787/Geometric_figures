using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geometric_figures.Class_geometric_figures
{
    class Class_rectangle: Class_grafig
    {
        public Class_rectangle() { }
        public override void Print_grfig(PictureBox pictureBox)
        {
            pictureBox.Refresh();
            figures = pictureBox.CreateGraphics();
            figures.DrawRectangle(pen, 10, 10, 50, 25);
        }
    }
}
