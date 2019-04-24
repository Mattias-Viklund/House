using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Util
    {
        public static int ReadInt(char prefix = '>')
        {
            Console.Write(prefix);
            string input = Console.ReadLine();

            int value = -1;

            if (Int32.TryParse(input, out value))
            {
                return value; 

            }
            else
                return ReadInt();

        }

        public static string ReadConfirm(string message, char prefix = '>')
        {
            Console.Write(prefix);
            string input = Console.ReadLine();

            if (input.Length == 0)
                return ReadConfirm(message);

            Console.WriteLine("'"+input+"' "+message);
            Console.WriteLine("Are you sure? [Y/N]");

            string confirm = Util.ReadLine().ToLower();

            if (confirm[0] == 'y')
                return input;

            return ReadConfirm(message);

        }

        public static string ReadLine(char prefix ='>')
        {
            Console.Write(prefix);
            string input = Console.ReadLine();
            return input;

        }
    }
}
