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
        public Class_grafig() 
        {
            pen = randon_color();
        }        
        public Pen randon_color()
        {
            Random rnd = new Random();
            int option = rnd.Next(0, 10);
            switch (option) 
            {
                case 0:
                    return  new Pen(Color.Red);                    
                case 1:
                    return new Pen(Color.Black);                    
                case 2:
                    return new Pen(Color.Orange);                    
                case 3:
                    return new Pen(Color.Aqua);                    
                case 4:
                    return new Pen(Color.Blue);                    
                case 5:
                    return new Pen(Color.BlueViolet);                    
                case 6:
                    return new Pen(Color.BurlyWood);                    
                case 7:
                    return new Pen(Color.Chocolate);                    
                case 8:
                    return new Pen(Color.DarkBlue);                    
                case 9:
                    return new Pen(Color.Yellow);                    
                case 10:
                    return new Pen(Color.LightYellow);
                default:
                    return new Pen(Color.Black);
            }

        }
        public abstract void print_grfig(PictureBox pictureBox);

    }
}
