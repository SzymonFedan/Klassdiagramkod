using System;

namespace Geography
{
    class Kontinent
    {
        protected bool stor;

        public Kontinent(bool stor)
        {
            this.stor = stor;
        }

        public string GetStor()
        {
            return stor ? "Stor" : "Inte stor";
        }

        public void BombaKontinent(int antal, string vilken)
        {
            Console.WriteLine($"bombar {antal} {vilken}.");
        }
    }

    class Land : Kontinent
    {
        protected string gammal;
        protected string namn;

        public Land(bool stor, string namn, string gammal) 
            : base(stor)
        {
            this.namn = namn;
            this.gammal = gammal;
        }

        public string GetGammal()
        {
            return gammal;
        }
    }

    class Stad : Land
    {
        private bool huvudstad;

        public Stad(bool stor, string namn, string gammal, bool huvudstad) 
            : base(stor, namn, gammal)
        {
            this.huvudstad = huvudstad;
        }

        public int GetInvanare()
        {
            return 1500;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kontinent kontinent = new Kontinent(true);
            Console.WriteLine("Kontinent: " + kontinent.GetStor());
            kontinent.BombaKontinent(2, "vilken");

            Land land = new Land(true, "Stor", "Australien");
            Console.WriteLine("Gammalt Land: " + land.GetGammal());

            Stad stad = new Stad(true, "Huvudstad", "Stad", true);
            Console.WriteLine("Stadens invånare: " + stad.GetInvanare());
        }
    }
}
