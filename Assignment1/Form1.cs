using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        Canvas canvas;
        DrawTo DrawTo;
        MoveTo MoveTo;
        Bitmap bitmap = new Bitmap(600, 480);
        

        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(Graphics.FromImage(bitmap));
            DrawTo = new DrawTo(Graphics.FromImage(bitmap));
            MoveTo = new MoveTo(Graphics.FromImage(bitmap)); ;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(bitmap, 0, 0);
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                String cmd = textBox1.Text.Trim().ToLower();    
                if (cmd == "sqr")
                {
                    canvas.DrawSqr(23);
                }
                if (cmd == "line")
                {
                    canvas.DrawLine(100,100);
                }
                if (cmd == "rect")
                {
                    canvas.DrawRect(23,50);
                }
                if (cmd == "drawto")
                {
                    
                    DrawTo.DrawLine(200, 100);

                }
                if (cmd == "moveto")
                {
                    MoveTo.moveto(300, 100);

                }

                textBox1.Text ="";
                Refresh();
            }

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Text = "Pressed";
            canvas.DrawRect(23, 50);
            canvas.DrawCirc(23);
            Refresh();
        }
    }
}
