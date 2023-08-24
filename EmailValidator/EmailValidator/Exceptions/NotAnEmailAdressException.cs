using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exceptions
{
    public class NotAnEmailAdressException : Exception
    {
        public NotAnEmailAdressException(string message) : base(message) { }
    }
}
