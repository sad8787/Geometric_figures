using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometric_figures.Class_geometric_figures;

namespace Geometric_figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            Class_polygon polygon = new Class_polygon();
            polygon.print_grfig(pictureBox1);
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            Class_rectangle rectangle = new Class_rectangle();
            rectangle.print_grfig(pictureBox1);
        }

        private void button_circle_Click(object sender, EventArgs e)
        {
            Class_circle circle = new Class_circle();
            circle.print_grfig(pictureBox1);
        }

        private void button_curve_Click(object sender, EventArgs e)
        {
            Class_curve curve = new Class_curve();
            curve.print_grfig(pictureBox1);
        }
    }
}
