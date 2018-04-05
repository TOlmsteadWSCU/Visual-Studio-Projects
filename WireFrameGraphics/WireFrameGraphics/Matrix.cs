using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrameGraphics
{
    public class Matrix
    {
        public float[,] matrix;
        public Matrix()
        {
            this.matrix = new float[4,4];
            this.matrix[0, 0] = 1;
            this.matrix[1, 1] = 1;
            this.matrix[2, 2] = 1;
            this.matrix[3, 3] = 1;
        }
        public Matrix multiply(Matrix m)
        {
            Matrix result = new Matrix();
            float[,] a = matrix;
            float[,] b = m.matrix;
            float[,] c = result.matrix;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
        //function muliplies matrix times a point
        public Point multPoint(Point p)
        {
            float x = matrix[0, 0] * p.x + matrix[0, 1] * p.y + matrix[0, 2] * p.z + matrix[0, 3] * 1;
            float y = matrix[1, 0] * p.x + matrix[1, 1] * p.y + matrix[1, 2] * p.z + matrix[1, 3] * 1;
            float z = matrix[2, 0] * p.x + matrix[2, 1] * p.y + matrix[2, 2] * p.z + matrix[2, 3] * 1;
            return new Point(x, y, z);
        }
        public static Matrix identity()
        {

            Matrix result = new Matrix();
            float[,] m = result.matrix;
            m[0, 0] = 1;
            m[1, 1] = 1;
            m[2, 2] = 1;
            m[3, 3] = 1;
            return result;
        }
        public static Matrix translation(Point p)
        {
            Matrix result = identity();
            float[,] m = result.matrix;
            m[0, 3] = p.x;
            m[1, 3] = p.y;
            m[2, 3] = p.z;
            return result;
        }
        public static Matrix RotateX(float p)
        {
            Matrix result = new Matrix();
            float[,] m = result.matrix;
            m[1, 1] = (float)Math.Cos(p);
            m[2, 1] = (float)Math.Sin(p);
            m[1, 2] = -(float)Math.Sin(p);
            m[2, 2] = (float)Math.Cos(p);
            return result;
        }
        public static Matrix RotateY(float theta)
        {
            Matrix result = new Matrix();
            float[,] m = result.matrix;
            m[0, 0] = (float)Math.Cos(theta);
            m[0, 2] = (float)Math.Sin(theta);
            m[1, 1] = 1;
            m[2, 0] = -(float)Math.Sin(theta);
            m[2, 2] = (float)Math.Cos(theta);
            return result;
        }
        public static Matrix RotateZ(float theta)
        {
            Matrix result = new Matrix();
            float[,] m = result.matrix;
            m[0, 0] = (float)Math.Cos(theta);
            m[0, 1] = -(float)Math.Sin(theta);
            m[1, 0] = (float)Math.Sin(theta);
            m[1, 1] = (float)Math.Cos(theta);
            return result;
        }
        public static Matrix scale(float s)
        {
            Matrix result = new Matrix();
            float[,] m = result.matrix;
            m[0, 0] = s;
            m[1, 1] = s;
            m[2, 2] = s;
            m[3, 3] = 1;
            return result;
        }
        public String toString()
        {
            string r = "[";
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    r = r + matrix[i, j] + " ";
                }
                if(i == 3)
                {
                    r = r + "]";
                }
                else
                {
                    r = r + "\n ";
                }
            }
            return r;
        }

    }
}
