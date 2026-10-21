using System;
using System.Collections.Generic;
using System.Text;

namespace katalog_produktow
{
    public class Produkt
    {
        public string Nazwa { get; set; } = "";
        public double Cena { get; set; }
        public int Ilosc { get; set; }
        public string Kategoria { get; set; } = "";

        //public override string ToString()
        //{
        //    return $"{Nazwa} ({Kategoria}): {Cena:F2} zł, Ilość: {Ilosc}";
        //}
    }
}
