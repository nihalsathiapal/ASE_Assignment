using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /// <summary>
    /// This canvas class 
    /// </summary>
    class Canvas
    {
        Graphics g;
        Pen pen;
        int xpos, ypos;
        Font drawFont = new Font("Arial", 16);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        

        public Canvas(Graphics gin)
        {
            g = gin;
            
            pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, 10, 10, 3, 3);
        }

        public void DrawLine(int toX,int toY) {

            g.DrawLine(pen,xpos,ypos, toX, toY);
            
        }

        public void DrawSqr(int w) {

            g.DrawRectangle(pen, xpos, ypos, xpos + w, ypos+w);

        }

        public void DrawRect(int h,int w) {

            g.DrawRectangle(pen, xpos, ypos, xpos + w, ypos + h);

        }

        public void DrawCirc(int r)
        {
            g.DrawEllipse(pen, xpos, ypos, xpos + (r * 2), ypos + (r * 2));
        }

        /*public void DrawTri()
        {
            float xDiff = oppPt.X - keyPt.X;
            float yDiff = oppPt.Y - keyPt.Y;
            float xMid = (oppPt.X + keyPt.X) / 2;
            float yMid = (oppPt.Y + keyPt.Y) / 2;

            // Define path with the geometry information only
            var path = new GraphicsPath();
            path.AddLines(new PointF[] {keyPt,new PointF(xMid + yDiff/2, yMid-xDiff/2),oppPt,});
            path.CloseFigure();

            // Fill Triangle
            g.FillPath(brush, path);

            // Draw Triangle
            g.DrawPath(pen, path);
        }*/

        public void DrawTo(int tox, int toy)
        {
            g.DrawLine(pen, xpos, ypos, tox, toy);
            //update turtle position to the end of the line
           /* xPos = tox;
            yPos = toy;*/
        }

        public void MoveTo(int tox,int toy){
            /*xPos = tox;
            yPos = toy;*/
        }

        public void DrawString(String error)
        {
            g.DrawString(error,drawFont,drawBrush,10,10);
        }
        
    }
}
