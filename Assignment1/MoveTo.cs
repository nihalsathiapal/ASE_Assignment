using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MoveTo: Cursor
    {
        int tox ,toy;
        CmdLine cmd;
        Pen pen = new Pen(Color.Red, 2);
        DrawTo drawto;
        Cursor cursor;
        Graphics gin;

        public MoveTo(int xpos,int ypos,int tox,int toy): base(xpos,ypos,tox,toy)
        {
            
            this.tox = tox;
            this.toy = toy;
            X = tox;
            Y = toy;
            SetValues(tox, toy);
        }

    }
}
 