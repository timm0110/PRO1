using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiši niz črk");
            String niz = Console.ReadLine();

            for(int i=0; i<niz.Length; i++)
            {
                niz = niz.Replace('a', '*');
                niz = niz.Replace('A', '*');
                niz = niz.Replace('e', '*');
                niz = niz.Replace('E', '*');
                niz = niz.Replace('i', '*');
                niz = niz.Replace('I', '*');
                niz = niz.Replace('o', '*');
                niz = niz.Replace('O', '*');
                niz = niz.Replace('u', '*');
                niz = niz.Replace('U', '*');
            }

            Console.WriteLine(niz);
        }
    }
}
