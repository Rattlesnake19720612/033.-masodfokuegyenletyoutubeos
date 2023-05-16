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

/*Ez egy C# program, amely megoldja a másodfokú egyenletet és kiszámítja annak gyökeit. A program bekéri az "a", "b" és "c" értékeket a felhasználótól, majd elvégzi a szükséges számításokat és kiírja a gyökértékeket.

Íme, hogyan működik a program lépésről lépésre:

A program importálja a szükséges könyvtárakat.
A program létrehozza a Main függvényt, amely a program belépési pontja.
Deklarálja és inicializálja az a, b, c, d, x1 és x2 változókat a megfelelő típussal.
A program kéri a felhasználótól az a értékét, majd átalakítja azt double típusba a Convert.ToDouble metódus segítségével.
Az if-else struktúra segítségével ellenőrzi, hogy az a értéke nulla-e. Ha igen, kiírja, hogy az egyenlet nem lehet másodfokú. Ha nem, akkor folytatja a számításokkal.
A program kéri a felhasználótól a b és c értékeit, majd átalakítja azokat double típusba.
Kiszámítja a d értékét a másodfokú egyenlet diszkriminánsaként: d = b * b - 4 * a * c.
Az if-else struktúra segítségével ellenőrzi, hogy a diszkrimináns kisebb-e mint 0. Ha igen, kiírja, hogy nincs valós megoldás. Ha nem, akkor folytatja a gyökértékek kiszámításával.
Kiszámítja az x1 és x2 értékeit a másodfokú egyenlet gyökformulájával: x1 = (-b + Math.Sqrt(d)) / (2 * a) és x2 = (-b - Math.Sqrt(d)) / (2 * a).
Kiírja az eredményt a konzolra a Console.WriteLine metódussal.
A program várja, hogy a felhasználó nyomjon meg egy billentyűt a kilépéshez.
Ezután a program kilép.*/
