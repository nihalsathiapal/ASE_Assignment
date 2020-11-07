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
        Graphics g;
        Canvas canvas;
        DrawTo drawto;
        MoveTo moveto;
        
        Form1 form1;
        
        
        public CmdLine(Graphics gin)
        {
            g = gin;
            canvas = new Canvas(g);
            drawto = new DrawTo(g);
            moveto = new MoveTo(g);
        }

        public void parseCmd(String cmd,int[] paramInt) {
            
            if (cmd.Equals("sqr") ==true)
            {
                if (paramInt.Length != 1)
                {
                    canvas.DrawString("Invalid Parameter");
                }
                else
                {
                    canvas.DrawSqr(paramInt[0]);                
                }
            }
            if (cmd.Equals("line")==true)
            {
                if (paramInt.Length != 2)
                {
                    canvas.DrawString("Invalid Parameter");
                }
                else
                {
                    canvas.DrawLine(paramInt[0], paramInt[1]);                    
                }
            }
            if (cmd.Equals("rect") == true)
            {
                if (paramInt.Length != 2)
                {
                    canvas.DrawString("Invalid Parameter");
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
                    canvas.DrawString("Invalid Parameter");
                }
                else
                {
                    drawto.DrawLine(paramInt[0], paramInt[1]);
                    
                }
            }
            if (cmd.Equals("circ") == true)
            {
                if (paramInt.Length != 1)
                {
                    canvas.DrawString("Invalid Parameter");
                }
                else
                {
                    canvas.DrawCirc(paramInt[0]);
                }
            }
            /*if (cmd.Equals("moveto") == true)
            {
                moveto.moveto(300, 100);
            }*/
        }
    }
}
