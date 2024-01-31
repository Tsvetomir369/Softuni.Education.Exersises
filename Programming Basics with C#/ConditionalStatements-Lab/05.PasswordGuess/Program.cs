using System;

namespace _05.PasswordGuess
{
    class program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isMatch = (password.Equals("s3cr3t!P@ssw0rd"));

            if (isMatch)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
