using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    internal interface IConsoleColoree
    {
        void WriteLine(string message);
        void Write(string message);

        void WriteReverse(string message);
    }
}
