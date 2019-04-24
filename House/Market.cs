// File Created 19-04-24
// Mattias Viklund

using System;
using System.Collections.Generic;

namespace House
{
    class Market
    {
        private List<Certificate> certificates = new List<Certificate>();
        public float marketRate = 1.0f;

        public Market()
        {
            GenerateProperties(10, 5, 2);

        }

        public void PrintProperties()
        {
            foreach (Certificate certificate in certificates)
            {
                Console.WriteLine(certificate.Property.GetPrefix()+" at "+certificate.Property.GetName() + ", Value " + certificate.Property.GetMarketValue()+"m");

            }
        }

        private void GenerateProperties(int houses, int apartments, int stores)
        {
            Random random = new Random();

            for (int i = 0; i < houses; i++)
            {
                House house = new House(random.Next(1, 20) * marketRate);
                Certificate certificate = new Certificate(house);
                certificates.Add(certificate);

            }

            for (int i = 0; i < apartments; i++)
            {
                Apartment apartment = new Apartment(random.Next(1, 20) * marketRate);
                Certificate certificate = new Certificate(apartment);
                certificates.Add(certificate);

            }

            for (int i = 0; i < stores; i++)
            {
                Store store = new Store(random.Next(1, 20) * marketRate);
                Certificate certificate = new Certificate(store);
                certificates.Add(certificate);

            }
        }

        public void Sell(Certificate property)
        {


        }

        public void Buy(Certificate property)
        {


        }
    }
}
