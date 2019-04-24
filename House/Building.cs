// File Created 19-04-24
// Mattias Viklund


using System;

namespace House
{
    abstract class Building
    {
        protected string name;
        protected float value;
        private string prefix;

        // Value (Millions)
        public Building(string name, float value, string prefix="")
        {
            this.name = name;
            this.value = value;
            this.prefix = prefix;

        }

        // Value (Millions)
        public Building(float value, string prefix = "")
        {
            GenerateName();
            this.value = value;
            this.prefix = prefix;

        }

        public string GetName()
        {
            return name;

        }

        public string GetPrefix()
        {
            return prefix;

        }

        private void TransferOwnership()
        {

        }

        public float GetMarketValue()
        {
            return value;

        }

        public void Purchase()
        {


        }

        public void Sell()
        {


        }

        private string[] streetNames =
            {
                "Wall St.", "Madison Av.", "Arthur St.", "Charles St.", "Houston St.",
                "Madison Av.", "Bartow Av.", "Fulton St.", "Hylan Blvd.", "Stureplan",
                "Adler St.", "Baker St.", "Brunel Rd.", "Cade Rd.", "Derry St.",
                "Artillerigatan", "Vasagatan", "Drottninggatan", "Smedjegatan", "Kungsgatan",
                "Clark St.", "Eldridge St.", "Brokedown St.", "Rundown Av.", "Grove St."

            };

        private static Random random = new Random();
        private void GenerateName()
        {
            this.name = streetNames[random.Next(streetNames.Length - 1)] + " " + random.Next(50);

        }
    }
}
