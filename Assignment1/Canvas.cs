using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Canvas
    {
        Graphics g;
        Pen pen;
        int xPos, yPos;

        public Canvas(Graphics gin)
        {
            g = gin;
            xPos = yPos = 20;
            pen = new Pen(Color.Black, 3);
            
        }

        public void DrawLine(int toX,int toY) {

            g.DrawLine(pen,xPos,yPos, toX, toY);
            
        }

        public void DrawSqr(int w) {

            g.DrawRectangle(pen, xPos, yPos, xPos + w, yPos+w);

        }

        public void DrawRect(int h,int w) {

            g.DrawRectangle(pen, xPos, yPos, xPos + w, yPos + h);

        }

        public void DrawCirc(int r)
        {
            g.DrawEllipse(pen, xPos, yPos, xPos + (r * 2), yPos + (r * 2));
        }

        public void DrawTo(int tox, int toy)
        {
            g.DrawLine(pen, xPos, yPos, tox, toy);
            //update turtle position to the end of the line
            xPos = tox;
            yPos = toy;
        }

        public void MoveTo(int tox,int toy){
            xPos = tox;
            yPos = toy;
        }
    }
}
