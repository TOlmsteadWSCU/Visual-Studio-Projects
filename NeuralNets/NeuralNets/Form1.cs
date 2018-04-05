using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNets
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

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex == 0)
            {
                for (int i = 0; i < trainNumber; i++)  // train the neural net i times -- change
                {
                    double x = rnd.NextDouble() * 2 * Math.PI;
                    double y = Math.Sin(x);
                    input[0] = x;
                    target[0] = y;
                    net.train(input, target);
                }
            }
            else if(comboBox.SelectedIndex == 1)
            {
                for(int i=0; i<5000; i++)
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
                
            }
            
            pictureBox1.Refresh();


        }
        public double drawCone(double x, double y)
        {
            int i = (int)((x + 1) / 2 * (imageWidth - 1));
            int j = (int)((y + 1) / 2) 8(imageHeight - 1);
            return Math.Max(0, 1 - d);
            //2d array that has image in it, 2 numbers tell width and height, add 1 div by 2
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Green);
            Graphics g = e.Graphics;
            
            if(comboBox.SelectedIndex == 0)
            {
                for (double i = 0; i < pictureBox1.Width; i += 5)
                {
                   /* input[0] = i / pictureBox1.Width * 2 * Math.PI;
                    g.FillRectangle(b1, (int)i, (int)(((Math.Sin(input[0]) + 1.5) / 3) * pictureBox1.Height), 3, 3); // Sin Wave
                    double[] ret = net.evaluate(input);
                    g.FillRectangle(b2, (int)i, (int)(((ret[0] + 1.5) / 3) * pictureBox1.Height), 3, 3); // Neural Net*/
                }
            }
            else if(comboBox.SelectedIndex == 1)
            {
                for(int i=0; i<100; i++)
                {
                    for(int j=0; j<100; j++)
                    {
                        double x = ((i - 50.0) / 50);
                        double y = ((j - 50.0) / 50);
                        double z = drawCone(x, y);
                        double[] ret = net.evaluate(t);
                        double netz = ret[0];
                        int c = (int)(z * 255);
                        int c1 = (int)(netz * 255);
                        c1 = Math.Max(0, Math.Min(1, c1));
                        Brush b = new SolidBrush(Color.FromArgb(255, c, c, c1));
                        g.FillRectangle(b, i * 5, j * 5, 5, 5);
                    }
                }
            }

        }

        /*public void display(PaintEventArgs e)
        {
           
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Green);
            Graphics g = e.Graphics;
            for (double i = 0; i < pictureBox1.Width; i += 5)
            {
                input[0] = i / pictureBox1.Width * 2 * Math.PI;
                g.FillRectangle(b1, (int)i, (int)(((Math.Sin(input[0]) + 1.5) / 3) * pictureBox1.Height), 3, 3); // Sin Wave
                double[] ret = net.evaluate(input);
                g.FillRectangle(b2, (int)i, (int)(((ret[0] + 1.5) / 3) * pictureBox1.Height), 3, 3); // Neural Net
            }
        }*/




        private void trainBar_Scroll(object sender, ScrollEventArgs e)
        {
            trainNumber = trainBar.Value;
            trainLabel.Text = "Trainings: " + trainNumber;
            //train(w, targ);
        }

        private void neuronsBar_Scroll(object sender, ScrollEventArgs e)
        {
            numb = neuronsBar.Value;
            neuronsLabel.Text = "Number of Neurons: " + numb;
            //train(x1, target1);
        }

        private void learningRateBar_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            learningRate = Math.Pow(10, (trackBar.Value));

            learnLabel.Text = "Learning Rate: " + learningRate;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
