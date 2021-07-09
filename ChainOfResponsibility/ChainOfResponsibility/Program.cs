
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static IPasswordValidator PasswordValidatorFactory()
        {
            Dictionary<string, string> EUServerPassword = new Dictionary<string, string>
            {
                ["a"] = "password",
                ["b"] = "12345678"
            };
            Dictionary<string, string> USServerPassword = new Dictionary<string, string>
            {
                ["tom"] = "password",
                ["jerry"] = "12345678"
            };

            IPasswordValidator pass1 = new PasswordValidatorCache();
            IPasswordValidator pass2 = new PasswordValidatorFormat8char();
            IPasswordValidator pass3 = new PasswordValidatorFormatNoWeirdCharacter();
            IPasswordValidator pass4 = new PasswordValidatorServer(EUServerPassword, "EU");
            IPasswordValidator pass5 = new PasswordValidatorServer(USServerPassword, "US");

            pass1.SetNext(pass2).SetNext(pass3).SetNext(pass4).SetNext(pass5);

            return pass1;
        }
        static void Main(string[] args)
        {
            IPasswordValidator chainValidator = PasswordValidatorFactory();

            Console.WriteLine("Enter username: ");
            string line;
            string username = null, password = null;

            while ((line = Console.ReadLine()) != "")
            {
                if (username == null)
                {
                    username = line;
                    Console.WriteLine("Enter password:");
                }
                else
                {
                    password = line;
                    if (chainValidator.ValidPassword(password, username) == null)
                        Console.WriteLine("Uncaught");

                    Console.WriteLine("Enter username: ");
                    username = null;
                    password = null;
                }
            }
        }
    }
}
