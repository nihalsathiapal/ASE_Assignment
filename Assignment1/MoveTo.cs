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
        
        Pen pen = new Pen(Color.Red, 2);
        Cursor cur = new Cursor();      
        public MoveTo()
        {

        }
        public MoveTo(int tox,int toy): base(tox,toy)
        {                
            Console.WriteLine("move to" + tox + toy);
            SetValues(tox, toy);
            
        }

    }
}
 