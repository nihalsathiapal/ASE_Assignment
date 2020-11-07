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
        int[] paramInt;
        
        String[] param = new String[] { };
        public CmdLine(Graphics gin)
        {
            g = gin;
            canvas = new Canvas(g);
        }

        public void parseCmd(String line) {
            line = line.Trim().ToLower();
            
            String[] split = line.Split(' ');
            
            String cmd = split[0];
            
            
            String[] param = split[1].Split(',');
            paramInt = Array.ConvertAll(param, int.Parse);
           
            if (cmd == "sqr")
            {
                if (paramInt.Length != 1)
                {
                    canvas.DrawSqr(paramInt[0]);
                }
            }
            if (cmd == "line")
            {
                Console.WriteLine(paramInt[1]);
                canvas.DrawLine(paramInt[0], paramInt[1]);
            }
            if (cmd == "rect")
            {
                canvas.DrawRect(paramInt[0], paramInt[1]);
            }
            if (cmd == "drawto")
            {

                DrawTo.DrawLine(200, 100);

            }
            if (cmd == "moveto")
            {
                MoveTo.moveto(300, 100);
            }
        }
    }
}
