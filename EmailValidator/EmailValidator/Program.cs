using ConsoleApp.Validations;
using ConsoleApp.Exceptions;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            var emailValidator = new EmailValidator();

            try
            {
                bool isValid = emailValidator.Validate("ali.aliyev@mail.com");
                Console.WriteLine(isValid);
            }
            catch (ShortEmailException ex)
            {
                Console.WriteLine("ShortEmailException: " + ex.Message);
            }
            catch (NotAnEmailAdressException ex)
            {
                Console.WriteLine("NotAnEmailAdressException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
