using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDanila
{
    class Variant1
    {
        public String ФИО { get; set; }
        public String Должность { get; set; }

        public int Зарплата
        {
            get { return _зарплата >= 0 ? _зарплата : throw new ArgumentNullException($"Беды с зарплатой"); }
            set { _зарплата = value > 0 ? value : throw new ArgumentNullException($"Беды с зарплатой"); }
        }

        private Int32 _зарплата;

        public Int32 ГодПоступленияНаРаботу { get; set; }

        public Variant1(string фИО, string должность, int зарплата, int годПоступленияНаРаботу)
        {
            ФИО = фИО ?? throw new ArgumentNullException(nameof(фИО));
            Должность = должность ?? throw new ArgumentNullException(nameof(должность));
            Зарплата = зарплата;
            ГодПоступленияНаРаботу = годПоступленияНаРаботу;
        }

        public Variant1()
        {
        }

        public override string ToString()
        {
            return
                $"ФИО:{ФИО} Должность: {Должность} Зарплата: {Зарплата} Год поступления на работу:{ГодПоступленияНаРаботу}";
        }
        public static void СтажБольше(Int32 стаж, ref List<Variant1> листсработниками)
        {
            bool такиеесть = false;
            Int32 годсейчас = DateTime.Now.Year;
            foreach (Variant1 Работник in листсработниками)
            {
                if (стаж<(годсейчас-Работник.ГодПоступленияНаРаботу))
                {
                    Console.WriteLine(Работник.ToString());
                    такиеесть = true;
                }
            }
            if (!такиеесть)
            {
                Console.WriteLine($"Таковых нет");
            }
        }
    }
}
