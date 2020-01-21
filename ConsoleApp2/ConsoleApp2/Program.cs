using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 46;
            string rezultatas = Convert.ToString(PatikrintiArSkaiciusYraLyginis(skaicius));
            Console.WriteLine($"Tikriname, ar skaicius {skaicius} yra lyginis...");
            Console.WriteLine($"Atsakymas yra {rezultatas}");
            Console.ReadLine();
        }

        public static bool PatikrintiArSkaiciusYraLyginis(int skaicius)
        {
            bool message;
            if (skaicius % 2 == 0)
            {
                message = true;
            }
            else
            {
                message = false;
            }
            return message;
        }
    }
}
