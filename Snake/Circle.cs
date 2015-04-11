using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color colour { get; set; }
        

        public Circle()
        {
            X = 0;
            Y = 0;
            colour = Color.Black;
        }
    }
}
