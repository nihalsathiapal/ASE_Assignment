using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DrawTo
    {

        Graphics g;
        Pen pen = new Pen(Color.Black);
        int xpos = 10, ypos = 10; //turtle position

        public DrawTo(Graphics g)
        {
            this.g=g;
                        
        }

        public void DrawLine(int tox,int toy)
        {
            g.DrawLine(pen, xpos, ypos, tox, toy);
            //update turtle position to the end of the line
            xpos = tox;
            ypos = toy;
        }
    }
}
