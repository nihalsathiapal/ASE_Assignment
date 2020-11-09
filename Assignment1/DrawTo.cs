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
        Cursor cursor;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        
        int xpos=10,ypos=10,tox,toy; //turtle position

        public DrawTo(int xpos,int ypos,int tox,int toy): base(xpos,ypos,tox,toy)
        {

            this.tox = tox;
            this.toy = toy;
            
            Console.WriteLine("drawto b4update pen" + xpos + ypos + tox+ toy);
            SetValues(tox, toy);
        }

    }
}
