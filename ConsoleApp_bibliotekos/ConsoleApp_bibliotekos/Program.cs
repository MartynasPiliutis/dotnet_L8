using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStruct;

namespace ConsoleApp_bibliotekos
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga;
            knyga.Name = "Vardas";
            knyga.Id = "0123";

            string localid = knyga.LocalID;

            Console.WriteLine(knyga.Name);
            Console.WriteLine(localid);
            Console.ReadLine();
        }
    }
}
