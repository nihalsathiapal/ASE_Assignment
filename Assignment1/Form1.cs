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
        Clear clear;
        Canvas canvas;      
        CmdLine command;
        Parser parser;
        Cursor cursor;
        Bitmap bitmap = new Bitmap(800, 800);
        Bitmap bitmap2 = new Bitmap(800, 800);
        Pen pen = new Pen(Color.Red, 2);
        
     
        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(Graphics.FromImage(bitmap));
            /*DrawTo = new DrawTo(Graphics.FromImage(bitmap));*/            
            command = new CmdLine(Graphics.FromImage(bitmap));
            parser = new Parser(Graphics.FromImage(bitmap));
            cursor = new Cursor(Graphics.FromImage(bitmap2));

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(bitmap, 10, 10);
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                String cmd = textBox1.Text;
                if (cmd == "")
                {
                    canvas.DrawString("Please enter Code");
                }
                else
                {
                    cmd = cmd.Trim().ToLower();
                    String[] line2 = Regex.Split(cmd, "\r\n");
                    parser.parseLine(line2);
                }
                textBox1.Text ="";
                Refresh();
            }

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            String cmd = textBox1.Text;
            if (cmd == "")
            {
                canvas.DrawString("Please enter Code");
            }
            else
            {
                cmd = cmd.Trim().ToLower();
                String[] line2 = Regex.Split(cmd, "\r\n");
                parser.parseLine(line2);
            }
            textBox1.Text = "";
            Refresh();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            clear = new Clear(g);            
            textBox1.Text = "";
            Refresh();
        }
       
    }
}
