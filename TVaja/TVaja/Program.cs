using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planeti p = Planeti.Zemlja;
            Console.WriteLine("Izbral sem "+p);
            int odd = (int)p;
            Console.WriteLine("Po oddaljenosti od sonca je " + odd);
            PeriodaPlaneti pp = PeriodaPlaneti.Jupiter;
            if (pp <= PeriodaPlaneti.Mars)
            {
                Console.WriteLine("Obhodni čas je " + (int)pp);
            }
            else
            {
                Console.WriteLine("Obhodni čas ni znan za " + pp);
            }
            Console.WriteLine("vnesi zaporedno številko tvojega meseca ");
            string odg = Console.ReadLine();
            int mojPlanet = int.Parse(odg);
            Planeti moj = (Planeti)mojPlanet;
            Console.WriteLine("Tvoj planet je " + moj);
            Console.ReadLine();
        }
    }
}
