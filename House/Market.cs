// File Created 19-04-24
// Mattias Viklund

using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Certificate> OwnedProperties(Owner owner)
        {
            var c = from cert in certificates where cert.Owner == owner select cert;
            return c.ToList();

        }

        public float Value(List<Certificate> certificates)
        {
            float value = 0f;
            foreach (Certificate certificate in certificates)
            {
                value += certificate.Property.GetMarketValue();

            }
            return value;

        }

        public void ListOwnedProperties(Owner owner)
        {
            var c = from cert in certificates where cert.Owned == true select cert;
            foreach (Certificate certificate in c)
            {
                Util.ColorText(certificate.Property.GetPrefix() + " at " +
                    certificate.Property.GetName() + ", Value " +
                    certificate.Property.GetMarketValue() + "m Owned by ",
                    new TextOption(certificate.Owner.GetName(), ConsoleColor.Yellow));

            }
            Console.ReadLine();

        }

        public void ListMarket()
        {
            var c = from cert in certificates where cert.Owned == false select cert;
            foreach (Certificate certificate in c)
            {
                Util.ColorText(certificate.Property.GetPrefix() + " at " +
                    certificate.Property.GetName() + ", Value " +
                    certificate.Property.GetMarketValue() + "m ", new TextOption("Available", ConsoleColor.Green));

            }
            Console.ReadLine();

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

        public void Sell(ref Owner owner, Certificate property)
        {
            owner.AddMoney(property.Property.GetMarketValue());
            property.SellCertificate();

        }

        public bool Buy(ref Owner owner, Certificate property)
        {
            if (owner.GetMoney() < property.Property.GetMarketValue())
                return false;

            owner.AddMoney(-property.Property.GetMarketValue());
            property.TransferCertificate(owner);
            return true;

        }
    }
}
