using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDanila
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Variant1> работники= new List<Variant1>();
            Variant1 работник1 = new Variant1($"Неважно Кто", $"Неважная",2000,2000);
            работники.Add(работник1);
            Variant1.СтажБольше(Int32.Parse(Console.ReadLine()),ref работники);
            Console.ReadKey();
        }
    }
}
