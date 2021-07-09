using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class PasswordValidatorFormat8char : PasswordValidator
    {
        public override bool? ValidPassword(string password, string username)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Password Validation failed: Password too short.");
                return false;
            }
            return base.ValidPassword(password, username);
        }
    }
}
