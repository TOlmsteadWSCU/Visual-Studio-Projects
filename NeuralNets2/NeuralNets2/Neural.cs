using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNets2
{
    public interface Neural
    {
        void initialize(int neurons, double noiseMagnitude);
        void setRate(double rate);
        void train(int count);
        double getError(int n);
        void paint(int width, int height, System.Drawing.Graphics g);
    }
}
