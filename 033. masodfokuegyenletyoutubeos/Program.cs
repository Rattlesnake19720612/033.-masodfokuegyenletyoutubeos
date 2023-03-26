using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033.masodfokuegyenletyoutubeos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;

            Console.Write("Add meg az a értékét! ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("\n Ez az egyenlet így nem lehet másodfokú!");
            }

            else
            {
                Console.Write("\n Add meg a b értékét! ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Add meg a c értékét! ");
                c = Convert.ToDouble(Console.ReadLine());
                d = b * b - 4 * a * c;
                if(d<0)
                {
                    Console.WriteLine("Nincs valós megoldás!");
                }

                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1={0}\tX2={1}", x1, x2);

                }
            }

            Console.WriteLine("A program enter leütése után kilép!");
            Console.ReadKey();
        }
    }
}
