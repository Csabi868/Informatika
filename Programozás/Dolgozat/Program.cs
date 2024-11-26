using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("1. feladat");
             const string nev = "Jázmin";
             string nev2 = Convert.ToString(Console.ReadLine());
             Console.WriteLine($" {nev} hercegnő a közelgő bálon {nev2} herceggel táncolna szívesen.");


             Console.WriteLine("2. feladat");
             string nev3 = Convert.ToString(Console.ReadLine());
             int ero1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"1. herceg {nev3}");
             Console.WriteLine($"1. ereje {ero1}");
             string nev4 = Convert.ToString(Console.ReadLine());
             int ero2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"2. herceg {nev4}");
             Console.WriteLine($"2. ereje {ero2}");

             if (ero1>ero2)
             {
                 Console.WriteLine($"{nev3} herceg erősebb, mint {nev4} herceg.");

             }
             if (ero1 < ero2)
             {
                 Console.WriteLine($"{nev4} herceg erősebb, mint {nev3} herceg.");

             }
             if (ero1 == ero2)
             {
                 Console.WriteLine($"{nev3} herceg ugyanolyan erős, mint {nev4} herceg.");

             }

             Console.WriteLine("3. feladat");

             Console.WriteLine("4. feladat");

             int x = Convert.ToInt32(Console.ReadLine());
             int y = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"x koordináta: {x}");
             Console.WriteLine($"y koordináta: {y}");
             int d =  (𝑥 − 5)2 + (𝑦 +5)2


              Console.WriteLine("5. feladat");
             Console.WriteLine("Mennyi út áll rendelkezésre a meneküléshez? (méterben add meg):");
             double tav = Convert.ToInt32(Console.ReadLine());
             const double seb = 360;
             Console.WriteLine($"A menekülési idő: {seb/tav} mp");
            Console.WriteLine("6. feladat");
            double szam1 = Convert.ToInt32(Console.ReadLine());
            double szam2 = Convert.ToInt32(Console.ReadLine());

            logikai = !((szam1 <= 21) && (szam1 >= 5)) || (szam2 = 1)&&!(szam1==szam2);
                if (logikai==true)
            {
                Console.WriteLine("Jaffar feleséget akar");
            }
            if (logikai=false)
            {
                Console.WriteLine("Jaffar cselédet keres);
            }
            Console.ReadKey();
        }
    }
}
