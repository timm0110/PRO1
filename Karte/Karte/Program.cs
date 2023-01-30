using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int barva = r.Next(4);
            int vrednost = r.Next(13);
            Console.WriteLine((Barva)barva + " " + (Vrednost)vrednost);
            Console.ReadLine();
        }
    }
}
