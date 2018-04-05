using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncing_Balls
{
    public partial class Form1 : Form
    {
        static float dx = 5;
        static float dy = 5;
        static float x = 5;
        static float y = 5;
        public Color color;
        List<Ball> blist = new List<Ball>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colorD1.ShowDialog();
            pic3.BackColor = colorD1.Color;
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*DialogResult diaResult = colorD1.ShowDialog();
            colorD1.FullOpen = false; ;
            if (DialogResult == DialogResult.OK)
            {
                this.BackColor = colorD1.Color;
                //Form1.BackColor = colorD1.Color;
                //Form1.
            }*/
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }
        private void pic1_MouseClick(object sender, MouseEventArgs e)
        {
            blist.Add(new Ball(e.X, e.Y, dx, dy, pic3.BackColor, scrollbar1.Value));
            double a = track1.Value * Math.PI / 180;
            double r = Math.Sqrt((dx * dx) + (dy * dy));
            double theta = Math.Atan2(dy, dx);
            theta = a + theta;
            dx = (int)(r * Math.Cos(theta));
            dy = (int)(r * Math.Sin(theta));
            pic2.Refresh();
            pic1.Refresh();
        }
        private void pic1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(Ball b in blist)
            {
                b.draw(g);
            }
        }
        private void pic1_Move(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Ball b in blist)
            {
                b.move();
            }
            lab2.Text = "The number of balls are: " + blist.Count;
            List<Ball> blist2 = new List<Ball>();
            foreach(Ball b in blist)
            {
                if (b.move() == false)
                    blist2.Add(b);
            }
            blist = blist2;
            pic1.Refresh();
        }

        private void pic2_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(p, 50, 50, dx + 50, dy + 50);
        }

        private void pic2_MouseClick(object sender, MouseEventArgs e)
        {
            dx = e.X - 50;
            dy = e.Y - 50;
            pic2.Refresh();
        }

        private void lab2_Click(object sender, EventArgs e)
        {

        }
    }
}
