using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];               
            }
            int count = 0;
            string input = Console.ReadLine();
            while (password != input)
            {
                count++;
                if (count == 4)
                {
                    Console.WriteLine("User {0} blocked!",userName);
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");

                input = Console.ReadLine();
            }

            Console.WriteLine("User {0} logged in.", userName);
        }
    }
}
