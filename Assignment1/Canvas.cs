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
        Pen pen = new Pen(Color.Red, 2);
        Pen pen2 = new Pen(Color.Black, 2);
        int xpos, ypos;
        Font drawFont = new Font("Arial", 16);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        Cursor cursor = new Cursor();

        public Canvas(Graphics gin)
        {
            this.g = gin;
            g.DrawRectangle(pen, 0,0, 3, 3); 
            
        }

        public void DrawLine(int toX,int toY) {

            g.DrawLine(pen2,xpos,ypos, toX, toY);
            
        }

        public void DrawSqr(int w) {

            g.DrawRectangle(pen2, cursor.xpos, cursor.ypos, xpos + w, ypos + w);

        }

        public void DrawRect(int w,int h) {

            g.DrawRectangle(pen2, cursor.xpos, cursor.ypos, xpos + w, ypos + h);

        }

        public void DrawCirc(int r)
        {
            g.DrawEllipse(pen2, cursor.xpos, cursor.ypos, xpos + (r * 2), ypos + (r * 2));
        }

        public void DrawTri(int w, int h)
        {
            int half = w/ 2;
            g.DrawRectangle(pen2, cursor.xpos, cursor.ypos, xpos + w, ypos + h);
            g.DrawLine(pen2, cursor.xpos, cursor.ypos + h, cursor.xpos + w, cursor.ypos + h); // base
            g.DrawLine(pen2, cursor.xpos, cursor.ypos + h, cursor.xpos + half, cursor.ypos); // left side
            g.DrawLine(pen2, cursor.xpos + w, cursor.ypos + h, cursor.xpos + half, cursor.ypos);
        }
            public void DrawTo(int xpos,int ypos,int tox, int toy)
        {
            g.DrawLine(pen2, cursor.xpos, cursor.ypos, tox, toy);
        }

        public void DrawString(String error)
        {
            g.DrawString(error,drawFont,drawBrush,10,10);
        }

        public void DrawCursor(int tox, int toy)
        {
            g.DrawRectangle(pen, tox, toy, 3, 3);
            cursor.SetValues(tox, toy);
        }

    }
}
