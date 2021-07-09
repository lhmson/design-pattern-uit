using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class BreadStore : IStore
    {
        public string BreadQuality()
        {
            return "Delicious";
        }

        public void accept(IPerson person)
        {
            person.visit(this);
        }
    }
}
