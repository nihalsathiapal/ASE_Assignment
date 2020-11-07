using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Parser
    {
        CmdLine cmdline;
        int[] paramInt;
        String[] param,split,line2;

        public Parser(Graphics g)
        {            
            cmdline = new CmdLine(g);
        }

        public void parseLine(String[] line)
        {
            if (line.Length == 1)
            {
                String[] split = line[0].Split(' ');

                String cmd = split[0];

                String[] param = split[1].Split(',');
                paramInt = Array.ConvertAll(param, int.Parse);

                cmdline.parseCmd(cmd, paramInt);

            }
            else
            {
                //Console.WriteLine(line[0]);

                for (int i = 0; i < line.Length; i++)
                {
                    line2 = line[i].Split(' ');                    
                    String cmd = line2[0];
                    //Console.WriteLine(line2[0]);
                    /*if(cmd.Equals("clear") == true)
                    {
                        canvas.DrawString("Please enter parameters");

                    }
                    if (split[1].Equals(" ")==true)
                    {
                        canvas.DrawString("Please enter parameters");
                        form1.

                    }*/

                    param = line2[1].Split(',');
                    paramInt = Array.ConvertAll(param, int.Parse);
                    cmdline.parseCmd(cmd, paramInt);
                    Console.WriteLine(line2[0]);
                    Console.WriteLine(line2[1]);
                }

               
            }

        }

    }
}
