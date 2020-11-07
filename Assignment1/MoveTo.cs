using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MoveTo
    {
        int xpos=10 ,ypos=10;
        Graphics g;
        public MoveTo(Graphics gin)
        {
            g = gin;
        }

        public void moveto(int xpos,int ypos,int tox, int toy)
        {
            xpos = tox;
            ypos = toy;
        }
    }
}
