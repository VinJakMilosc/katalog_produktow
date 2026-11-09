using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace katalog_produktow
{
    public class Produkt : INotifyCollectionChanged
    {
        public string Nazwa { get; set; } = "";
        private double cena;
        public double Cena
        {
            get { return cena; }
            set { cena = value < 0 ? 0 : value; }
        }
        private int ilosc;
        public int Ilosc
        {
            get { return ilosc; }
            set { ilosc = value < 0 ? 0 : value; Zmiana(nameof(Ilosc)); }
        }
        public string Kategoria { get; set; } = "";

        //public override string ToString()
        //{
        //    return $"{Nazwa} ({Kategoria}): {Cena:F2} zł, Ilość: {Ilosc}";
        //}

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Zmiana(string nazwaWlasciwosci)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nazwaWlasciwosci));
        }
    }
}
