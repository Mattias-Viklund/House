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
            game.Start();

        }
    }

    class Game
    {
        private Market market = new Market();
        private Player player;

        public Game()
        {
            Setup();
            player = new Player(Util.ReadConfirm("Enter your name.","Will be your name."));

        }

        private void Setup()
        {
            Console.ForegroundColor = Util.CONSOLE_FG;
            Console.BackgroundColor = Util.CONSOLE_BG;

        }

        public void Start()
        {
            while (true)
            {
                Cycle();

            }
        }

        private void Cycle()
        {
            Console.Clear();
            Console.WriteLine("-- House Broker --");
            Console.WriteLine();
            Console.WriteLine("-Player "+player.GetName());
            Console.WriteLine(" Money: " + player.GetMoney()+"m");
            Console.WriteLine(" Properties: "+market.OwnedProperties(player).Count);
            Console.WriteLine(" Total Value: " + market.Value(market.OwnedProperties(player)));
            Console.WriteLine();
            Console.WriteLine("- Options -");
            Console.WriteLine(" 1) View Property Listings");
            Console.WriteLine(" 2) View Owner Properites");
            Console.WriteLine(" 3) Train Skills");
            Console.WriteLine();
            Console.WriteLine("Q) Quit");

            int choice = Util.ReadInt();

            switch (choice)
            {
                case 1: market.ListMarket(); break;
                case 2: market.ListOwnedProperties(player); break;
                case 3: break;

            }
        }

        private void Sell()
        {


        }

        private void Buy()
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
