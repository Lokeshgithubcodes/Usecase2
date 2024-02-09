using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases2
{
    class GenericsDemo
    {
        public void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main()
        {
            GenericsDemo gd = new GenericsDemo();
            Print(10);
        }
    }
}
