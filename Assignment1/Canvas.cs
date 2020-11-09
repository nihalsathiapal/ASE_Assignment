﻿using System;
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
            
            
        }

        public void DrawLine(int toX,int toY) {

            g.DrawLine(pen2,xpos,ypos, toX, toY);
            
        }

        public void DrawSqr(int w) {

            g.DrawRectangle(pen2, cursor.xpos, cursor.ypos, xpos + w, ypos + w);

        }

        public void DrawRect(int h,int w) {

            g.DrawRectangle(pen2, cursor.xpos, cursor.ypos, (xpos + w), (ypos + h));

        }

        public void DrawCirc(int r)
        {
            g.DrawEllipse(pen2, cursor.xpos, cursor.ypos, xpos + (r * 2), ypos + (r * 2));
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
