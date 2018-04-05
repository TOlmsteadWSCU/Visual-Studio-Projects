using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bouncing_Balls
{
    class Ball
    {
        public float x;
        public float y;
        public float dx;
        public float dy;
        public Color color;
        public static int count = 0;
        public int number;
        public int lifeTime;
        public Ball(float x, float y, float dx, float dy, Color color, int lifeTime)
        {
            this.number = count;
            count++;
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.color = color;
            this.lifeTime = lifeTime;
        }
        public void draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x, y, 20, 20);
            Font font = new Font("myNewFont", 10);
            SolidBrush myBrush2 = new SolidBrush(Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
            g.DrawString("" + number, font, myBrush2, (int)x, (int)y);

        }
        public bool move()
        {
            x = (dx / 10) + x;
            y = (dy / 10) + y;
            float gravity = 2;
            dy = gravity + dy;
            if (x < 0)
            {
                x = -x;
                y = -y;
                dx = -dx;
            }
            else if (y < 0)
            {
                x = -x;
                y = -y;
                dy = -dy;
            }
            else if(x>280)
            {
                dx = -dx;
                if (x == 290)
                    x = 270;
                else if (x == 300)
                    x = 260;
            }
            else if(y>280)
            {
                dy = -dy;
                if (x == 290)
                    x = 270;
                else if (x == 300)
                    x = 260;
            }
            lifeTime--;
            if (lifeTime <= 0)
                return true;
            else
                return false;
        } 
    }
}
