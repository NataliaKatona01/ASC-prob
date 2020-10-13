using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1310
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programul afiseaza in ordine inversa cifrele unui numar din maxim 3 cifre
             * Exemplu: n=123 -> se afiseaza 321
             */
            int n;
            Console.WriteLine("Introduceti un numar natural de maxim 3 cifre");
            n = int.Parse(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine(n);
            }
            else
            {
                if (n < 100)
                {
                    Console.WriteLine($"{n % 10}{n / 10}");
                }
                else
                    Console.WriteLine(${n % 10 }{ n / 10 % 10}{ n / 100});
            }
        }
    }
}
