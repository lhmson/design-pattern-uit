using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class PasswordValidatorCache : PasswordValidator
    {
        private string password;
        private string username;

        public override bool? ValidPassword(string password, string username)
        {
            if (password == this.password && username == this.username)
            {
                Console.WriteLine("Validated by cache");
                return true;
            }
            bool? result = base.ValidPassword(password, username);
            if (result == true)
            {
                this.password = password;
                this.username = username;
            }
            return result;
        }
    }
}
