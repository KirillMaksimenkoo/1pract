using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pract
{
    internal class Tab
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {
            return Math.Pow(Math.E, -2 * x) + Math.Pow(2 * Math.Pow(x, 4) + Math.Pow(x, 2) + 1, (1 / 7));
        }
        private double f2(double x)
        {
            return (Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - 4 * x) / (Math.Pow(x, 5) * (1 / Math.Tan(2 * Math.Pow(x, 3))));
        }
        private double f3(double x)
        {
            return (Math.Pow(Math.Cos(Math.Pow(x + 2, 3)), 2)) / (2 * Math.Pow(Math.Pow(x, 3), 1 / 2) * Math.Sin(Math.Pow(x, 3)));
        }

        public void FuncTub(double xn = 2.9, double xk = 17.48, double h = 0.1, double a = 0.3)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i,0] = x;
                xy[i,1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
