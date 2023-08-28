using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    internal class ConsoleBleue : IConsoleColoree
    {
        public void WriteLine(string message) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(message);
            Console.ResetColor();
        }

        public void WriteReverse(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
