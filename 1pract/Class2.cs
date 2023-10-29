using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pract
{
    internal class Arrays
    {
        public bool error = false;
        
        int[] a;
        int length = 10;

        public int Lenght
        {
            get { return length; }
            set { length = value; }
        }

        public Arrays()
        {
            a = new int[length];
        }

        public Arrays(int[] mas)
        {
            a = mas;
        }

        public int this[int i]
        {
            get {
                if (i >= 0 && i < length) return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < length && value >= -40 && value <= 50) a[i] = value;

                else error = true;
            }
        }
        
        public Arrays(int size)
        {
            Lenght = size;

            a = new int[length];
            Random rand = new Random();

            for(int i = 0; i < length; i++)
            {
                a[i] = rand.Next(-40, 50);
            }
        }

        public int FirstNegativeTemperatureIndex()
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i] < 0)
                {
                    return i+1;
                }
            }

            return -1; // Якщо від'ємної температури не знайдено
        }

    }
}
