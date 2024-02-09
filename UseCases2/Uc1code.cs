using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases2
{
    class Uc1code
    {
        public int compareTo1(int x, int y, int z)
        {
            int maximum = x;
            //int k = 0;
            if (y.CompareTo(maximum) > 0)
            {
                maximum = y;
                //k = 1;
            }
            if (z.CompareTo(maximum) > 0)
            {
                maximum = z;
                //k = 2;

            }
            return maximum;


        }

        public float compareTo2(float x, float y, float z)
        {
            float maximum = x;
            //int k = 0;
            if (y.CompareTo(maximum) > 0)
            {
                maximum = y;
                //k = 1;
            }
            if (z.CompareTo(maximum) > 0)
            {
                maximum = z;
                //k = 2;

            }
            return maximum;


        }

        public string compareTo3(string x, string y, string z)
        {
            if (x.Length > y.Length && x.Length > z.Length)
            {
                return x;
            }
            else if (y.Length > z.Length && y.Length > x.Length) { return y; }

            else
            {
                return z;
            }
        }

    }
}
