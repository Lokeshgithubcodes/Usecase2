using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases2
{
     class UsingGenerics
    {
        public T compareTo<T>(params T[] values) where T : IComparable<T>
        {


            T maxi = values[0];



            for (int i = 1; i < values.Length; i++)

            {
                if (typeof(T) == typeof(string))
                {

                    if (values[i].ToString().Length > maxi.ToString().Length)
                    {
                        maxi = values[i];
                    }
                }
                if (values[i].CompareTo(maxi) > 0)
                {
                    maxi = values[i];
                }
            }
            Print(maxi);
            return maxi;
        }
        public void Print<T>(T maxi)
        {
            //Console.WriteLine(maxi);
        }

    }
}
