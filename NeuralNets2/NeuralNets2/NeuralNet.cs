using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNets2
{
    public class NeuralNet
    {
        public int ninput;
        public int noutput;
        public int n;
        public double lrate;
        public double[,] synone;
        public double[,] syntwo;
        public double[] medin;
        public double[] medout;
        public double[] error;
        public double[] sigma;
        public double[] sigmoid;
        public double[] input;
        Random r = new Random(1);

        public NeuralNet(int ninput, int noutput, int n, double lrate)
        {
            this.ninput = ninput;
            this.noutput = noutput;
            this.n = n;
            this.lrate = lrate;
            synone = new double[ninput + 1, n];
            for (int i = 0; i < ninput + 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double weight = r.NextDouble() * 0.1;
                    synone[i, j] = weight;
                }
            }
            syntwo = new double[n, noutput];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < noutput; j++)
                {
                    double weight = r.NextDouble() * 0.1;
                    syntwo[i, j] = weight;
                }
            }
            medin = new double[n];
            medout = new double[n];
            error = new double[noutput];
            sigma = new double[n];
            sigmoid = new double[n];
            input = new double[ninput + 1];


        }

        public double[] evaluate(double[] x)
        {
            double[] output = new double[noutput];
            for (int i = 0; i < x.Length; i++)
            {
                input[i] = x[i];
            }
            input[ninput] = 1;
            for (int i = 0; i < n; i++)
            {
                medin[i] = 0;
                for (int j = 0; j < ninput + 1; j++)
                {
                    medin[i] = medin[i] + synone[j, i] * input[j];
                }
                medout[i] = Math.Tanh(medin[i]);
            }
            for (int i = 0; i < noutput; i++)
            {
                output[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    output[i] = output[i] + syntwo[j, i] * medout[j];
                }
            }
            return output;


        }

        public void train(double[] x, double[] target)
        {
            double[] output = evaluate(x);
            for (int i = 0; i < noutput; i++)//noutput
            {
                error[i] = target[i] - output[i];
            }

            for (int i = 0; i < noutput; i++)//noutput
            {
                for (int j = 0; j < n; j++)
                {
                    syntwo[j, i] = syntwo[j, i] + lrate * medout[j] * error[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                sigma[i] = 0;
                for (int j = 0; j < noutput; j++)//noutput
                {
                    sigma[i] = sigma[i] + error[j] * syntwo[i, j];
                }
                sigmoid[i] = 1 - (medout[i]) * (medout[i]);
            }

            for (int i = 0; i < ninput + 1; i++)//ninput
            {
                for (int j = 0; j < n; j++)
                {

                    double delta = lrate * sigmoid[j] * sigma[j] * input[i];
                    synone[i, j] = synone[i, j] + delta;
                }
            }
        }

    }
}
