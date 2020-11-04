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

        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 10;
            pen = new Pen(Color.Black, 3);
        }

        public void DrawLine(int toX,int toY) {

            g.DrawLine(pen,xPos,yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }

        public void DrawSqr(int w) {

            g.DrawRectangle(pen, xPos, yPos, xPos + w, yPos+w);

        }

        public void DrawRect(int h,int w) {

            g.DrawRectangle(pen, xPos, yPos, xPos + w, yPos + h);

        }
    }
}
