using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pract
{
    internal class Arrays2D
    {
        public bool error = false;

        int x_length = 5;
        int y_length = 5;

        private int[,] a;

        public int X_Lenght
        {
            get { return x_length; }
            set { x_length = value; }
        }
        public int Y_Lenght
        {
            get { return y_length; }
            set { y_length = value; }
        }
        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < x_length && j >= 0 && j < y_length) return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < x_length && j >= 0 && j < y_length && value >= -5 && value <=5) a[i, j] = value;

                else error = true;
            }
        }
    public Arrays2D(int a_length, int b_length)
        {
            if (a_length > 5 || b_length > 5)
            {
                throw new ArgumentException("Розмір матриці не повинен бути більшим за 5Х5!");
            }
            X_Lenght = a_length;
            Y_Lenght = b_length;

            a = new int[x_length, y_length];

            Random rand = new Random();

            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    a[i, j] = rand.Next(1, 100);
                }
            }
        }
        public (int, int, int) FindMaxElement
        {
            get { 
            int maxElement = a[0, 0];
            int row = 0;
            int col = 0;

            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    if (a[i, j] > maxElement)
                    {
                        maxElement = a[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
                return (maxElement, row, col);
            }
        }


    }

}
