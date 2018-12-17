using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Hodnota je " + x);

            double dnum = 0.1d;
            float fnum = 0.2f;
            decimal decnum = 5.5m;

            char c = 'c';
            string jmeno = "John";

            Console.WriteLine(""+dnum+fnum+decnum+c+jmeno);
        }
    }
}
