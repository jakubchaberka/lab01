using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");

            string imie = args[0];
            string nazwisko = args[1];

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

            int wiek = Convert.ToInt32(args[2]);

            if (wiek < 67)
            {
                Console.WriteLine(" Do emerytury zostało Ci {0} lat", 67 - wiek);
            }
            else
            {
                Console.WriteLine(" Jesteś emerytem");
            }


        }
    }
}

