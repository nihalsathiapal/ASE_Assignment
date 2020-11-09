using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    class Parser
    {
        CmdLine cmdline;
        int[] paramInt;
        String[] param,line2;
        Canvas canvas;
        int x, y, tox, toy;

        public Parser(Graphics g)
        {            
            cmdline = new CmdLine(g);
            canvas = new Canvas(g);
        }

        public void parseLine(String[] line)
        {
            
            String[] commands = { "sqr", "circle", "rect", "drawto", "moveto" };

            if (line.Length == 1)
            {                
                String[] split = line[0].Split(' ');                
                String cmd = split[0];
                if (commands.Contains(cmd) == true)
                {
                    if (cmd.Equals("clear") == true)
                    {

                        canvas.DrawString("Clear");

                    }
                    else if (split.Length < 2)
                    {
                        canvas.DrawString("No Parameters Given");

                    }
                    else 
                    {
                        
                        String[] param = split[1].Split(',');
                        String dump = param[0];
                        
                        if (isNumeric(dump))
                        {
                                paramInt = Array.ConvertAll(param, int.Parse);
                                cmdline.parseCmd(cmd, paramInt);
                            
                        }
                        else {
                            
                            canvas.DrawString("Parameters is not numeric");
                        }
                    }
                }
                else
                {
                    canvas.DrawString("Invalid Command");
                }
            }
            else
            {              

                for (int i = 0; i < line.Length; i++)
                {
                    line2 = line[i].Split(' ');                    
                    String cmd = line2[0];               
                    param = line2[1].Split(',');
                    paramInt = Array.ConvertAll(param, int.Parse);
                    cmdline.parseCmd(cmd, paramInt);
                    
                }
                               
            }

        }
        public static bool isNumeric(string dump)
        {
            return int.TryParse(dump, out int n);
        }
        

    }
}
