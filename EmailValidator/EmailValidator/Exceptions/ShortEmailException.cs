using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exceptions
{
    public class ShortEmailException : Exception
    {
        public ShortEmailException(string message) : base(message) { }
    }
}
