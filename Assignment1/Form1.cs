using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        Canvas canvas;
        DrawTo DrawTo;
        MoveTo MoveTo;
        CmdLine command;
        Parser parser;
        Bitmap bitmap = new Bitmap(600, 480);
        TextBox tb;

        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(Graphics.FromImage(bitmap));
            DrawTo = new DrawTo(Graphics.FromImage(bitmap));
            MoveTo = new MoveTo(Graphics.FromImage(bitmap));
            command = new CmdLine(Graphics.FromImage(bitmap));
            parser = new Parser(Graphics.FromImage(bitmap));
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
                String cmd = textBox1.Text;
                cmd = cmd.Trim().ToLower();
                String[] line2 = Regex.Split(cmd,"\r\n");
                parser.parseLine(line2);
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
