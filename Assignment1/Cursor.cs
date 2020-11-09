using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Cursor
    {
        Pen pen = new Pen(Color.Red, 2);
        int tox=10, toy=10;
        private int xpos,ypos;
        public Cursor(int x,int y,int tox, int toy)
        {
            x = tox;
            y = toy;
            Console.WriteLine("cursor xpos=" + tox + "toY=" + toy);
        }
        
        public int X
        {   
            get
            {
                return xpos;
            }
            set
            {
                xpos = value;
            }
        }

        public int Y
        {
            get
            {
                return ypos;
            }
            set
            {
                ypos = value;
            }
        }

        public void SetValues(int x,int y)
        {
            this.xpos = x;
            this.ypos = y;
            
        }
       
    }
}
