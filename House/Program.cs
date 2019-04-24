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
            Game game = new Game();
            game.Aids();
            Console.ReadLine();

        }
    }

    class Game
    {
        private Market market = new Market();

        public Game()
        {

        }

        public void Aids()
        {
            market.PrintProperties();

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

    class Available : Owner
    {
        public Available()
            : base("Available")
        {

        }
    }

    class Store : Building
    {
        public Store(string name, float value)
            : base(name, value, "Store")
        {

        }

        public Store(float value)
            : base(value, "Store")
        {

        }
    }

    class House : Building
    {
        public House(string name, float value)
            : base(name, value, "House")
        {

        }

        public House(float value)
            : base(value, "House")
        {

        }
    }

    class Apartment : Building
    {
        public Apartment(string name, float value)
            : base(name, value, "Apartment")
        {

        }

        public Apartment(float value)
            : base(value, "Apartment")
        {

        }
    }
}
