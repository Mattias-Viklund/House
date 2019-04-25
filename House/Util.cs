using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Util
    {
        public static ConsoleColor CONSOLE_FG = ConsoleColor.White;
        public static ConsoleColor CONSOLE_BG = ConsoleColor.Black;

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

        public static string ReadConfirm(string question, string message, char prefix = '>')
        {
            Console.WriteLine(question);
            Console.Write(prefix);
            string input = Console.ReadLine();

            if (input.Length == 0)
                return ReadConfirm(question, message);

            Console.WriteLine("'"+input+"' "+message);
            Console.WriteLine("Are you sure? [Y/N]");

            string confirm = Util.ReadLine().ToLower();

            if (confirm[0] == 'y')
                return input;

            return ReadConfirm(question, message);

        }

        public static string ReadLine(char prefix ='>')
        {
            Console.Write(prefix);
            string input = Console.ReadLine();
            return input;

        }

        public static void ColorText(params TextOption[] options)
        {
            foreach (TextOption option in options)
            {
                Console.ForegroundColor = option.fg_color;
                Console.BackgroundColor = option.bg_color;
                Console.Write(option.text);

            }
            Console.ForegroundColor = CONSOLE_FG;
            Console.BackgroundColor = CONSOLE_BG;
            Console.Write("\n");

        }
    }

    struct TextOption
    {
        public string text;
        public ConsoleColor fg_color;
        public ConsoleColor bg_color;

        public TextOption(string text, ConsoleColor fg_color = ConsoleColor.White, ConsoleColor bg_color = ConsoleColor.Black)
        {
            this.text = text;
            this.fg_color = fg_color;
            this.bg_color = bg_color;

        }

        public static implicit operator TextOption(string s)
        {
            return new TextOption(s);

        }
    }
}
