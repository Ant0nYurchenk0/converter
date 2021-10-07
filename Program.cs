using System;

namespace Converter
{
    class Converter
    {
        private decimal usd;
        private decimal eur;
        public Converter(decimal usd, decimal eur)
        {
            this.usd = usd;
            this.eur = eur;
        }
        public decimal ToUsd(decimal uah)
        {
            return uah / this.usd;
        } 
        public decimal ToEur(decimal uah)
        {
            return uah / this.eur;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter(27.15m, 29.93m);
            Console.WriteLine(Math.Round(converter.ToUsd(27.15m), 2));
            Console.WriteLine(Math.Round(converter.ToEur(29.5m), 2));
        }
    }
}
