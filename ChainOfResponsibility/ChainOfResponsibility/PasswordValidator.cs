using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IPasswordValidator
    {
        public IPasswordValidator SetNext(IPasswordValidator validator);
        public bool? ValidPassword(string password, string username);
    }

    public abstract class PasswordValidator : IPasswordValidator
    {
        IPasswordValidator nextValidator;
        public virtual IPasswordValidator SetNext(IPasswordValidator validator)
        {
            return nextValidator = validator;
        }

        public virtual bool? ValidPassword(string password, string username)
        {
            return nextValidator?.ValidPassword(password, username);
        }
    }
}
