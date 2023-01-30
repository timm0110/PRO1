using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tip klica? 0 - mobilno, 1 - stacionarno");
            string odg = Console.ReadLine();
            int t = int.Parse(odg);
            TipiKlica tip = (TipiKlica)t;
            Console.WriteLine("Koliko minut? ");
            string minute = Console.ReadLine();
            double znesek;
            if (tip == TipiKlica.KlicVMobilno)
            {
                znesek = double.Parse(minute) * 0.03;
                Console.WriteLine("Uporabnik dolguje " + znesek + ".");
                Console.ReadLine();
            }
            else
            {
                znesek = double.Parse(minute) * 0.2;
                Console.WriteLine("Uporabnik dolguje " + znesek + ".");
                Console.ReadLine();
            }

        }
    }
}
