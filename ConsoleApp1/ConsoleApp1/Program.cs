using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string eilute = "ABCDEFGHIJKL";
            string rezultatas = ApverciaStringa(eilute);
            Console.WriteLine($"Jusu eilute: {eilute}");
            Console.WriteLine($"Apverstas stringas: {rezultatas}"); ;
            Console.ReadLine();
        }

        public static string ApverciaStringa(string eilute)
        {
            string atvirksciaEilute = "";
            for (int i = eilute.Length-1; i >= 0; i--)
            {
                atvirksciaEilute += eilute[i];
            }
            return atvirksciaEilute;
        }
    }
}
