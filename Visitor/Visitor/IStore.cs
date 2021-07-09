using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IStore
    {
        public void accept(IPerson person);
    }
}
