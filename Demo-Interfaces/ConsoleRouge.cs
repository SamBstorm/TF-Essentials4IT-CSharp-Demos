using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    internal class ConsoleRouge : IConsoleColoree
    {
        public void WriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(message);
            Console.ResetColor();
        }

        public void WriteReverse(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
