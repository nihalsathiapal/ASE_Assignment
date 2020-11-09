using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DrawTo: Cursor
    {
        MoveTo moveto;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        
        int xpos=10,ypos=10,tox,toy; //turtle position
        public DrawTo()
        {

        }
        public DrawTo(int xpos,int ypos,int tox,int toy): base(xpos,ypos)
        {         
            
        }

        public void draw(Graphics gin)
        {
            g = gin;
        }
    }
}
