using ConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Validations
{
    public class EmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Length < 10)
            {
                throw new ShortEmailException("This is not considered an email.");
            }

            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAdressException("This email is not ending with the way it should be.");
            }
            return true;
        }
    }
}
