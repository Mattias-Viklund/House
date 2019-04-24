// File Created 19-04-24
// Mattias Viklund

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }

    class Player : Owner
    {
        public Player(string name)
            : base(name)
        {


        }
    }

    class Broker : Owner
    {

    }

    class Market
    {
        private List<Certificate> certificates = new List<Certificate>();

    }

    struct Certificate
    {
        public readonly Owner Owner;
        public readonly Building Property;

        public Certificate(Owner owner, Building property)
        {
            this.Owner = owner;
            this.Property = property;

        }
    }

    abstract class Owner
    {
        private string name;
        private int money;

        public Owner(string name)
        {
            this.name = name;

        }

        public Owner()
        {
            this.name = GetRandomName();

        }


        #region Random Name
        private static string[] nameList =
        {
            "Jeff", "Mark", "Steve", "Brian", "Dude",
            "Cool Dude", "Mr. Spielberg", "Stanley",
            "Voldemort", "Gandalf", "Tyrone"

        };

        public static string GetRandomName()
        {
            Random rng = new Random();
            return nameList[rng.Next(nameList.Length-1)];

        }
        #endregion

    }

    class Store : Building
    {
        public Store(string name, int value) 
            : base(name, value)
        {

        }
    }

    class House : Building
    {
        public House(string name, int value) 
            : base(name, value)
        {

        }
    }

    abstract class Building
    {
        protected string name;
        protected int value;

        public Building(string name, int value)
        {

        }

        public building

        private void TransferOwnership()
        {

        }

        public int GetMarketValue()
        {
            return value;

        }

        public void Purchase()
        {


        }

        public void Sell()
        {


        }
    }

    class Apartment : Building
    {
        public Apartment(string name, int value) 
            : base(name, value)
        {

        }

        public void Aids()
        {

        }
    }
}
