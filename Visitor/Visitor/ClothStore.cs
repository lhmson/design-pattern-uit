using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ClothStore : IStore
    {
        public string ClothQuality()
        {
            return "Durable";
        }

        public void accept(IPerson person)
        {
            person.visit(this);
        }
    }
}
