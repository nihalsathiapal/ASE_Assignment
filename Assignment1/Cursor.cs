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
        public int xpos,ypos;        
        Graphics g;
        Canvas canvas;
        public Cursor()
        {
            
        }

        public Cursor(Graphics gin)
        {
            this.g = gin;
            canvas = new Canvas(g);
            
            Console.WriteLine("Cursor" + X + ypos);
        }

        public Cursor(int x,int y)
        {
            xpos = x;
            ypos = y;
            //canvas.DrawCursor(xpos, ypos);
            Console.WriteLine("Cursor wparam" + X + ypos);
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
            
            //drawcursor(xpos,ypos);
        }

        

    }
}
