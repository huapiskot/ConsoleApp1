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

            Console.WriteLine("Decimal: {0}, double: {1}, float: {2}",decnum,dnum,fnum);

            char c = 'c';
            string jmeno = "John";

            bool isDone = false;

            Console.WriteLine(""+dnum+fnum+decnum+c+jmeno+isDone);

            int cislo = 15;
            string strCislo = cislo.ToString();
            float ff =3.5f;
            cislo = Convert.ToInt32(ff); //4
            cislo = (int)ff; //3
            Console.WriteLine(cislo);

            var something = 10;
            Console.WriteLine(something);

            Console.WriteLine(typeof(int).IsPrimitive);


        }
    }
}
