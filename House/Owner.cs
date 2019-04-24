// File Created 19-04-24
// Mattias Viklund

using System;

namespace House
{
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

        public string GetName()
        {
            return name;

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
            return nameList[rng.Next(nameList.Length - 1)];

        }
        #endregion

    }
}
