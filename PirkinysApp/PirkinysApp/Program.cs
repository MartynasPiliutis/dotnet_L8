using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirkinysStruct;

namespace PirkinysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirkinys darzoves = new Pirkinys();
            
            darzoves.PrekesKiekis = 15;
            darzoves.PrekesKaina = 0.15;
            darzoves.PrekesPavadinimas = "bulves";

            Console.WriteLine(darzoves.PrekesPavadinimas);
            Console.WriteLine(darzoves.KainaViso);
            Console.ReadLine();
        }


    }
}
