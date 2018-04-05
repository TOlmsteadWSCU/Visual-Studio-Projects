using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NeuralNets2
{
    public partial class Form1 : Form
    {
        public static int numb = 10;
        NeuralNet net = new NeuralNet(1, 1, numb, learningRate); // mess /w learning rate
        Random rnd = new Random();
        public static int trainNumber;
        double[] input = new double[2];
        double[] target = new double[1];
        public double[] t = new double[2];
        public static double learningRate = .01;


        public String[,] picture = new string[50, 50];
        public int[,] world = new int[50, 50];
        string str;
        public int imageHeight, imageWidth, d;
        public Form1()
        {
            InitializeComponent();
            for(int i=0; i<50; i++)
            {
                for(int j=0; j<50; j++)
                {
                    if (picture[i, j] == " ")
                    {
                        world[i, j] = 0;
                    }
                    else if (picture[i, j] == "*")
                    {
                        world[i, j] = 1;
                    }
                }
            }
        }

        private async void fileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(label1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public double drawCone(double x, double y)
        {
            int i = (int)(((x + 1) / 2) * (imageWidth - 1));
            int j = (int)(((y + 1) / 2) * (imageHeight - 1));
            return Math.Max(0, 1 - d);
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5000; i++)
            {
                double a = rnd.NextDouble() * 2 - 1;
                double b = rnd.NextDouble() * 2 - 1;
                double z = drawCone(a, b);
                input[0] = a;
                input[1] = b;
                target[0] = z;
                t[0] = a;
                t[1] = b;
                net.train(input, target);
            }
            worldPanel.Refresh();
        }

        private void homer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color[] color = new Color[] { Color.White, Color.Black };
            Brush br = new SolidBrush(color[1]);
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (world[i, j] == 1)
                    {
                        //Console.WriteLine("Painting a cell!");
                        g.FillRectangle(br, i * 10, j * 10, 10, 10);
                        double x = ((i - 50.0) / 50);
                        double y = ((j - 50.0) / 50);
                        double z = drawCone(x, y);
                        double[] ret = net.evaluate(t);
                        double netz = ret[0];
                        int c = (int)(z * 255);
                        int c1 = (int)(netz * 255);
                        c1 = Math.Max(0, Math.Min(1, c1));
                        Brush b = new SolidBrush(Color.FromArgb(255, c, c, c1));
                        g.FillRectangle(b, i * 10, j * 10, 10, 10);
                    }
                }
            }
        }

        private void homer_Click(object sender, EventArgs e)
        {

        }

        private void worldPanel_Paint(object sender, PaintEventArgs e)
        {

            //Console.WriteLine("Painting!");
            Graphics g = e.Graphics;
            Color[] color = new Color[] { Color.White, Color.Black };
            Brush br = new SolidBrush(color[1]);
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (world[i, j] == 1)
                    {
                        //Console.WriteLine("Painting a cell!");
                        g.FillRectangle(br, i * 10, j * 10, 10, 10);
                    }
                }
            }
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            if(fileChooser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader file = new StreamReader(fileChooser.FileName);
                    //file.ReadToEnd();
                    int rownum = 0;
                    while((str = file.ReadLine()) != null && rownum < world.Length)
                    {
                        for(int i=0; i<str.Length - 1 && i < world.Length; i++)
                        {
                            char at = str[i];
                            //Console.WriteLine(at);
                            if(at.Equals(' '))
                            {
                                world[i, rownum] = 0;
                            }
                            else if(at.Equals('*'))
                            {
                                world[i, rownum] = 1;
                            }
                        }
                        rownum++;
                    }
                }
                catch
                {
                    error.Text = "File Error!!!!!";
                }
                worldPanel.Refresh();
                homer.Refresh();
            }
        }
    }
}
