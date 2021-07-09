using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class PasswordValidatorFormatNoWeirdCharacter : PasswordValidator
    {
        public override bool? ValidPassword(string password, string username)
        {
            if (password.Any(character => character < ' ' || character > '~'))
            {
                Console.WriteLine("Password Validation failed: password contains weird characters.");
                return false;
            }
            return base.ValidPassword(password, username);
        }
    }
}
