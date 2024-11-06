using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork5
{
    internal class Task1_option9
    {
        static void Main(string[] args)
        {
            double x, y = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть x = ");
            x = double.Parse(Console.ReadLine());
            if (x > -3)
                y = Math.Sin(Math.Pow(x,y)+1);
            if (x >= 0)
               y = 2 * x + Math.Pow(Math.Log(4.4), 2);
            if (Math.Abs(x) < -3 && x < 0)
                y = Math.Pow(Math.E, (1 / x));
            Console.WriteLine("При x = {0} обчислено y = {1}",x,y);
            Console.ReadKey();
        }
    }
}
