using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi temperaturo");
            String beri = Console.ReadLine();
            int temp = int.Parse(beri);

            if (temp <= 10)
                Console.WriteLine("zelo mrzla");
            else if(temp<=20)
                Console.WriteLine("hladna");
            else if(temp <= 30)
                Console.WriteLine("topla");
            else if (temp <= 50)
                Console.WriteLine("vroča");
            else
                Console.WriteLine("zelo vroča");
        }
    }
}
