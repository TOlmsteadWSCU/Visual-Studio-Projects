using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife1
{
    public partial class Form1 : Form
    {
        public static int score = 0;
        public static int numCities = 5;
        public List<GObj> missileWorld = new List<GObj>();
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
        int[,] world = new int[50, 50];
        int[,] world1 = new int[50, 50];
        bool playOn = false;
        public int population;
        public int death;
        public int birth;
        public bool mdown = false;
        public bool moved = false;
        public int x = 0;
        public int y = 0;
        public float z = 10;
        public float panx = 0;
        public float pany = 0;
        public int xv;
        public int yv;
        public int countGeneration = 0;
        public Form1()
        {
            InitializeComponent();
            worldPanel.Refresh();
        }
        public void move()
        {
            birth = 0;
            death = 0;
            population = 0;
            countGeneration++;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    int count = 0;
                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            count = count + world[ir(k), ir(l)];
                        }
                    }
                    if (world[i, j] == 1)
                    {
                        if (count == 3 || count == 4)
                        {
                            world1[i, j] = 1;
                            population++;
                        }
                        else
                        {
                            world1[i, j] = 0;
                            death++;
                        }
                    }
                    else
                    {
                        if (count == 3)
                        {
                            world1[i, j] = 1;
                            population++;
                            birth++;
                        }
                        else
                        {
                            world1[i, j] = 0;
                            
                        }
                    }
                }
            }
            int[,] temp = world;
            world = world1;
            world1 = temp;
            generationNumber.Text = "Genrations: " + countGeneration + "Population: " + population + " Births: " + birth + " Deaths: " + death;
            
            worldPanel.Refresh();
            
            
        }
        public int pop(int[,] life, int x, int y)
        {
            if (life[x, y] == 1)
                return 1;
            else
                return 0;

        }
        private void worldPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Color[] color = new Color[] { Color.Blue, Color.Black, Color.Orange, Color.Aqua, Color.Brown, Color.Gold };
            Random rc = new Random();
            int randomColor = rc.Next(6);
            Brush br = new SolidBrush(color[randomColor]);
            for (int i = 0; i < 50; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    if(world[i,j] == 1)
                    {
                        //Brush br = new SolidBrush(color[6]);
                        g.FillRectangle(br, i * 10, j * 10, 10, 10);
                    }
                }
            }
            foreach(GObj o in missileWorld)
            {
                o.display(g);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            countGeneration = 0;
            population = 0;
            generationNumber.Text = "Genrations: " + countGeneration + " Population: "+population;
            for (int i = 0; i < 50; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    world[i, j] = 0;
                }
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    world[20, 20] = 1;
                    world[21, 20] = 1;
                    world[19, 21] = 1;
                    world[20, 21] = 1;
                    world[20, 22] = 1;
                    worldPanel.Refresh();
                }
            }

        }
        private int ir(int i)
        {
            return (i + 50) % 50;
        }
        private void worldPanel_MouseClick(object sender, MouseEventArgs e)
        {
            world[e.X / 10, e.Y / 10] = 1 - world[e.X / 10, e.Y / 10];//WHY DO I ALWAYS GET OUT OF BOUNDS EXCEPTIONS HERE
            target = new Point2(e.X, e.Y);
            missileWorld.Add(new Missile(start, target));
            worldPanel.Refresh();
        }

        private void generationButton_Click(object sender, EventArgs e)
        {

            //countGeneration++;
            move();
            
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            move();
            List<GObj> newWorld = new List<GObj>();
            foreach (GObj o in missileWorld)
            {
                newWorld.AddRange(o.move());
                foreach (GObj v in missileWorld)
                {
                    o.interact(v);
                }
            }
            for(int i=0; i<50; i++)
            {
                for(int j=0; j<50; j++)
                {
                    if(world[i,j] == 1)
                    {
                        foreach(GObj s in missileWorld)
                        {

                            s.envelop(new Point2(i * 10 + 5, j * 10 + 5), 5);
                        }
                    }
                }
            }
            missileWorld = newWorld;
            cityLabel2.Text = numCities + "";
            scoreLabel2.Text = score + "";
            worldPanel.Refresh();
            if (numCities <= 0 || Launcher.g == true)
            {
                //statusLabel.Text = "Game Over!";
                clock.Stop();
            }

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            initWorld();
            worldPanel.Height = 400;
            worldPanel.Width = 800;
            numCities = 6;
            int count = 0;
            if(playOn == false)
            {
                clock.Start();
                playButton.Text = "Pause";
                playOn = true;
                
            }
            else if(playOn == true)
            {
                playButton.Text = "Play";
                clock.Stop();
                playOn = false;
                //count++;
            }
            clock.Start();
            //generationNumber.Text = "Generations: " + count;
        }//Play Button
        public void initWorld()
        {
            missileWorld.Clear();
            score = 0;
            Color[] colors = { Color.Blue, Color.Beige, Color.BurlyWood, Color.Yellow, Color.White, Color.Red, Color.Purple };
            for(int i=0; i<7; i++)
            {
                if (i != 3)
                {
                    missileWorld.Add(new City(colors[i], (i + 1) * 100));
                }
                else
                {
                    missileWorld.Add(new Launcher(colors[i], (i + 1) * 100));
                }
            }//for loop
            missileWorld.Add(new Enemy());
        }//initWorld method creates the cities

        private void speed_Scroll(object sender, ScrollEventArgs e)
        {
            clock.Interval = speed.Value;
        }

        private void size_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int lineCount = 0;
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile1.FilterIndex = 2;
            saveFile1.RestoreDirectory = true;
            if(saveFile1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile1.FileName))
                {
                    for(int i=0; i<world.GetLength(0); i++)
                    {
                        String str = "";
                        for (int j = 0; j < world.GetLength(1); j++)
                        {
                            if (world[j, i] == 1)
                            {
                                str += "*";
                            }
                            else
                                str += " ";

                        }  
                        writer.WriteLine(str);
                        
                    
                    }
                }
            }
            
            

        }//save/restore file button

        private void wrap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void worldPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = true;
            moved = false;
            xv = e.X;
            yv = e.Y;
        }

        private void worldPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mdown)
            {
                panx = panx + (e.X - xv) / z;
                pany = pany + (e.Y - yv) / z;
                moved = true;
                x = e.X;
                y = e.Y;
            }
            worldPanel.Refresh();
        }

        private void worldPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mdown = false;
            if(!moved)
            {
                x = e.X;
                y = e.Y;
            }
            worldPanel.Refresh();
        }

        private void shootButton_Click(object sender, EventArgs e)
        {
            /*target = new Point2(e.X, e.Y);
            missileWorld.Add(new Missile(start, target));*/
        }
        //public bool cellAlive()
    }//Form1 Class
}//namespace Game Of Life
