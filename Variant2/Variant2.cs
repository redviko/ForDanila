using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    class Variant2
    {
        public String НазваниеНачальногоМаршрута { get; set; }
        public String НазваниеКонечногоМаршрута { get; set; }
        public Int32 НомерМаршрута { get; set; }

        public Variant2(string названиеНачальногоМаршрута, string названиеКонечногоМаршрута, int номерМаршрута)
        {
            НазваниеНачальногоМаршрута = названиеНачальногоМаршрута ?? throw new ArgumentNullException(nameof(названиеНачальногоМаршрута));
            НазваниеКонечногоМаршрута = названиеКонечногоМаршрута ?? throw new ArgumentNullException(nameof(названиеКонечногоМаршрута));
            НомерМаршрута = номерМаршрута;
        }

        public Variant2()
        {
        }

        public override string ToString()
        {
            return
                $"Название Начального Маршрута:{НазваниеНачальногоМаршрута} НазваниеКонечногоМаршрута: {НазваниеКонечногоМаршрута} Номер Маршрута:{НомерМаршрута}";
        }

        public static void ПоНомеру(Int32 номер, ref List<Variant2> маршруты)
        {
            bool такиеесть = false;
            foreach (Variant2 маршрут in маршруты)
            {
                if (номер==маршрут.НомерМаршрута)
                {
                    Console.WriteLine(маршрут.ToString());
                    такиеесть = true;
                }
            }

            if (!такиеесть)
            {
                Console.WriteLine($"Таких маршрутов нет");
            }
        }
    }
}
