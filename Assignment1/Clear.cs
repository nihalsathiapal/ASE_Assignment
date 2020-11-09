using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Clear
    {
        Pen pen = new Pen(Color.Red, 2);
        Graphics g;
        
        public Clear(Graphics g)
        {
            this.g = g;
            g.Clear(Color.Gray);
            g.DrawRectangle(pen, 0, 0, 3, 3);

        }
    }
}
 