using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases2
{
    class GenericMax<T> where T : IComparable<T>
    {
        public T variable1;
        public T variable2;
        public T variable3;

        public GenericMax(T var1, T var2, T var3)
        {
            variable1 = var1;
            variable2 = var2;
            variable3 = var3;
        }

        public T FindMax()
        {
            return FindMax(variable1, variable2, variable3);
        }

        public static T FindMax(T value1, T value2, T value3)
        {
            T max = value1;

            if (typeof(T) == typeof(string))
            {
                if (value2.ToString().Length > max.ToString().Length)
                {
                    max = value2;
                }

                if (value3.ToString().Length > max.ToString().Length)
                {
                    max = value3;
                }
            }
            else
            {
                if (value2.CompareTo(max) > 0)
                {
                    max = value2;
                }

                if (value3.CompareTo(max) > 0)
                {
                    max = value3;
                }
            }

            return max;
        }
    }
}
