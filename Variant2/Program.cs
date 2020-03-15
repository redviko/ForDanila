using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Variant2> маршруты = new List<Variant2>();
            Variant2 маршрут = new Variant2($"Хуй", $"Моча", 228);
            маршруты.Add(маршрут);
            Variant2.ПоНомеру(int.Parse(Console.ReadLine()),ref маршруты);
            Console.ReadKey();
        }
    }
}
