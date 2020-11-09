using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1
{
    class CmdLine
    {
        Pen pen = new Pen(Color.Red, 2);
        Pen pen2 = new Pen(Color.Black, 2);
        Graphics g;
        Canvas canvas;
        DrawTo drawto;
        MoveTo moveto;
        Cursor cursor;
        int xpos, ypos,x,y,tox,toy;

        public CmdLine(Graphics gin) 
        {
            this.g = gin;
            canvas = new Canvas(g);
            cursor = new Cursor();
            
        }


        public void parseCmd(String cmd,int[] paramInt) {
            
            if (cmd.Equals("sqr") ==true)
            {
                if (paramInt.Length != 1)
                {
                    canvas.DrawString("Invalid Parameter\n");
                }
                else
                {
                    canvas.DrawSqr(paramInt[0]);
                }
            }
            
            if (cmd.Equals("rect") == true)
            {
                if (paramInt.Length != 2)
                {
                    canvas.DrawString("Invalid Parameter\n");
                }
                else
                {
                    canvas.DrawRect(paramInt[0], paramInt[1]);                    
                }
            }
            if (cmd.Equals("drawto") == true)
            {
                if (paramInt.Length != 2)
                {
                    canvas.DrawString("Invalid Parameter\n");
                }
                else
                {
                    g.Clear(Color.Gray);
                    drawto = new DrawTo(xpos,ypos,paramInt[0], paramInt[1]);                    
                    canvas.DrawTo(xpos, ypos,paramInt[0], paramInt[1]);
                    canvas.DrawCursor(paramInt[0], paramInt[1]);

                }
            }
            if (cmd.Equals("circle") == true)
            {
                if (paramInt.Length != 1)
                {
                    canvas.DrawString("Invalid Parameter\n");
                }
                else
                {
                    canvas.DrawCirc(paramInt[0]);
                }
            }
            if (cmd.Equals("tri") == true)
            {
                if (paramInt.Length != 1)
                {
                    canvas.DrawString("Invalid Parameter\n");
                }
                else
                {
                   // canvas.DrawTri();
                }
            }
            if (cmd.Equals("moveto") == true)
            {
                moveto = new MoveTo(paramInt[0], paramInt[1]);
                canvas.DrawCursor(paramInt[0], paramInt[1]);                

            }
        }
    }
}
