using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class PasswordValidatorServer : PasswordValidator
    {
        public PasswordValidatorServer(Dictionary<string, string> username_password_pair, string servername)
        {
            this.username_password_pair = username_password_pair;
            this.servername = servername;
        }
        Dictionary<string, string> username_password_pair;
        string servername;

        public override bool? ValidPassword(string password, string username)
        {
            if (username_password_pair.ContainsKey(username))
            { 
                if (username_password_pair[username] == password)
                {
                    Console.WriteLine("Validated by server " + servername);
                    return true;
                }
                else
                {
                    Console.WriteLine("Unvalidated by server " + servername);
                    return false;
                }
            }
            
            return base.ValidPassword(password, username);
        }
    }
}
