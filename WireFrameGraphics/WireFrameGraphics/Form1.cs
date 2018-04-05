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

namespace WireFrameGraphics
{
    public partial class Form1 : Form
    {
        // public List<Circle> points = new List<Circle>();
        // public Matrix matrix = Matrix.RotateZ(.1f).multiply(Matrix.RotateX(.05f));
        public Matrix matrix = new Matrix();
        public Matrix here = new Matrix();
        public float x, y, z;
        public string line = "";
        public List<Line> lines = new List<Line>();
        public Graphics g;
        public Color color = new Color();
        public Form1()
        {
            InitializeComponent();
            Point prev = null;
            string line = "";
            StreamReader file = new StreamReader(@"C:\Users\Owner\Documents\Graphics Programming\WireFrameNote.txt");
            while (((line = file.ReadLine()) != null))
            {

                if (line.Equals(""))
                {
                    prev = null;
                    //MessageBox.Show("" + reset);
                }
                else
                {
                    char c2 = line[0];
                    if (char.IsLetter(c2))
                    {
                        color = Color.FromName(line);
                    }
                    else
                    {
                        //if (!(char.IsLetter(c2) || line.StartsWith(" ")))
                        //{
                        int comma1 = line.IndexOf(',');
                        int comma2 = line.IndexOf(',', comma1 + 1);
                        string x1 = line.Substring(0, comma1);
                        string y1 = line.Substring(comma1 + 1, (comma2 - comma1) - 1);
                        string z1 = line.Substring(comma2 + 1);
                        //MessageBox.Show(y1);
                        x = float.Parse(x1);
                        y = float.Parse(y1);
                        z = float.Parse(z1);
                        Point p = new Point(x, y, z);
                        //matrix = matrix.multiply(matrix);
                       // Circle c1 = new Circle(p, color, 5);
                        if (prev != null)
                        {
                            Line l1 = new Line(prev, p, 5, color);
                            lines.Add(l1);
                        }
                        prev = p;
                       
                       // points.Add(c1);
                    }//else statement
                }
                
            }
            file.Close();
           // importFile();
            panel.Refresh();
        }
        
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
            paintPoint(e.Graphics);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Matrix rx = Matrix.RotateX((float)(RotateX.Value / (2 * Math.PI)));
            Matrix ry = Matrix.RotateY((float)(rotateY.Value / (2 * Math.PI)));
            Matrix rz = Matrix.RotateZ((float)(rotateZ.Value / (2 * Math.PI)));
            Matrix s = Matrix.scale(scale.Value/100.0f);
            Matrix tran = Matrix.translation(new Point(translateX.Value, translateY.Value, translateZ.Value));
            matrix = tran.multiply(s.multiply(rz).multiply(ry).multiply(rx));
            here = here.multiply(matrix);
            Console.WriteLine("RX: \n" + rx.toString());
            Console.WriteLine("RY: \n" + ry.toString());
            Console.WriteLine("RZ: \n" + rz.toString());
            Console.WriteLine("SCALE: \n" + s.toString());
            Console.WriteLine("Tran: \n" + tran.toString());
            Console.WriteLine("matrix: \n" + matrix.toString());
            Console.WriteLine("here: \n" + here.toString());
            //if doesnt work reverse
            panel.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Line l4 in lines)
            {
                matrix = Matrix.RotateX(30);
                l4.paint(g, matrix);
            }
        }

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{

        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void rotateX_Scroll(object sender, EventArgs e)
        {
                
        }
        private void rotateY_Scroll(object sender, EventArgs e)
        {
            
        }

        private void rotateZ_Scroll(object sender, EventArgs e)
        {
            
        }

        private void scale_Scroll(object sender, EventArgs e)
        {
            
        }

        private void translateX_Scroll(object sender, EventArgs e)
        {
            
        }

        private void translateY_Scroll(object sender, EventArgs e)
        {
            
        }

        private void translateZ_Scroll(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //importFile();
        }

        public void paintPoint(Graphics g)
        {
                Pen pen = new Pen(color);        
                foreach (Line l3 in lines)
                {
                    l3.paint(g, here);
                }
        }//pointPaint method
        //public void importFile()
        //{
        //    string line;
        //    StreamReader file = new StreamReader(@"C:\Users\Owner\Documents\Graphics Programming\WireFrameNote.txt");
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        textBox1.Text += line + Environment.NewLine;
        //    }
        //    file.Close();
        //}
    }
}
//make class to hold the model