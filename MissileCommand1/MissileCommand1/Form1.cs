using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissileCommand1
{
    public partial class Form1 : Form
    {
        public static int score = 0;
        public static int numCities = 5;
        public List<GObj> world = new List<GObj>();
        public static Point2 target = new Point2(200, 200);
        public float Tx;
        public float Ty;
        public const int bottom = 400; 
        public const int rightEdge = 800;
        public const int cityWidth = 40; 
        public const int cityHeight = 20;
        public const int launcherWidth = 20;
        public const int launcherHeight = 10;
        public const int launcherX = 400;
        public const int launcherY = bottom - launcherHeight;
        public const float shellVelocity = 4;
        public const float missileVelocity = 20;
        Point2 start = new Point2(395, 395);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            initWorld();
            gameLabel.Height = 400;
            gameLabel.Width = 800;
            statusLabel.Text = "Playing";
            numCities = 6;
            clock.Start();
        }
        public void initWorld()
        {
            world.Clear();
            score = 0;
            Color[] colors = { Color.Aqua, Color.Pink, Color.Yellow, Color.Black, Color.Blue, Color.Green, Color.BlueViolet };
            for (int i = 0; i < 7; i++)
            {
                if (i != 3)
                {
                    world.Add(new City(colors[i], (i + 1) * 100));
                }
                else
                {
                    world.Add(new Launcher(colors[i], (i + 1) * 100));
                }
            }
            world.Add(new Enemy());

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            /*List<GObj> newWorld = new List<GObj>();
            foreach (GObj o in world)
            {
                newWorld.AddRange(o.move());
            }
            world = newWorld;
            cityLabel2.Text = numCities + "";
            gameLabel.Refresh();*/
        }

        private void gameLabel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (GObj o in world)
            {
                o.display(g);
            }
        }

        private void gameLabel_MouseClick(object sender, MouseEventArgs e)
        {
            target = new Point2(e.X, e.Y);
            world.Add(new Missile(start, target));
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            List<GObj> newWorld = new List<GObj>();
            foreach (GObj o in world)
            {
                newWorld.AddRange(o.move());
                foreach (GObj v in world)
                {
                    o.interact(v);
                }
            }

            world = newWorld;
            cityLabel2.Text = numCities + "";
            scoreLabel2.Text = score + "";
            gameLabel.Refresh();
            if (numCities <= 0 || Launcher.g == true)
            {
                statusLabel.Text = "Game Over!";
                clock.Stop();
            }
        }

        private void gameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
