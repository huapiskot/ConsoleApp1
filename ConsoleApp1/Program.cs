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

            Console.WriteLine("Decimal: {0}, double: {1}, float: {2}", decnum, dnum, fnum);

            char c = 'c';
            string jmeno = "John";

            bool isDone = false;

            Console.WriteLine("" + dnum + fnum + decnum + c + jmeno + isDone);

            int cislo = 15;
            string strCislo = cislo.ToString();
            float ff = 3.5f;
            cislo = Convert.ToInt32(ff); //4
            cislo = (int)ff; //3
            Console.WriteLine(cislo);

            var something = 10;
            Console.WriteLine(something);

            Console.WriteLine(typeof(int).IsPrimitive);

            DateTime dt = new DateTime(); //01.01.0001 0:00:00
            Console.WriteLine(dt);

            dt = new DateTime(2018, 12, 20, 13, 15, 20, 20); //20.12.2018 13:15:20:20
            Console.WriteLine(dt);

            dt = DateTime.Now; //20.12.2018 11:16:42
            Console.WriteLine(dt);
            Console.WriteLine();

            Console.WriteLine(dt.ToShortDateString());  //20.12.2018
            Console.WriteLine(dt.ToShortTimeString());  //11:19
            Console.WriteLine(dt.ToLongDateString());   //čtvrtek 20. prosince 2018
            Console.WriteLine(dt.ToLongTimeString());   //11:19:12

            Console.WriteLine(dt.AddDays(11));

            string formatedDate = string.Format("Datum je {0:yyyy MM dd: HH mm ss}", dt); //Datum je 2018 12 20: 11 37 22
            string formatedDate2 = string.Format("Datum je {0:yyyy MMMM ddd: HH mm ss}", dt); //Datum je 2018 prosinec čt: 11 39 42
            string s = dt.ToString("yyyy-MM-dd HH:mm:ss"); //2018-12-20 11:46:40


            Console.WriteLine(string.Format("Datum je {0:yyyy MMMM 'nejaky text yyyy uprostred' ddd: HH mm ss}", dt));

            var day = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(day); //Friday

            ushort sh = 125;
            switch (sh)
            {
                case 1: Console.WriteLine("xx"); break;
                case 0: Console.WriteLine("err!"); break;
                default: Console.WriteLine("aaaa"); break;
            }

            int res = -999;
            //pokud se nepodari parsovani, tak hodnota v promenne res je nulova!
            //bool ret = int.TryParse(Console.ReadLine(), out res); //vstup: "x", vystup: false/res:0
            //bool ret2 = int.TryParse(Console.ReadLine(), out res); //vstup: "10", vystup: true/res:10

            //Console.WriteLine("ret: {0}, num: {1}", ret2, res);


            const double pi = 3.14;
            //pi = 1;


            string str = "Game of Thrones";
            //Poradi znaku: 012345678901234
            Console.WriteLine(str.IndexOf('o')); //5
            Console.WriteLine(str.LastIndexOf('o')); //11

            Console.WriteLine(str.Substring(5)); //of Thrones
            Console.WriteLine(str.Substring(5, 2)); //of   [index znaku,pocet znaku]

            Console.WriteLine(str.Remove(3)); //Gam  [vymaze vse od 3. indexu znaku, vcetne]
            Console.WriteLine(str.Remove(3, 2)); //Gamof Thrones   [vymaze od 3. indexu znaku vcetne v delce dvou znaku] 

            Console.WriteLine(str.Insert(1, "XXX")); //GXXXame of Thrones

            string xy = "bflm";
            Console.WriteLine("text {0}", xy);
            Console.WriteLine($"text {xy}");

        }
    }
}
