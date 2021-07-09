using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Customer : IPerson
    {
        public void visit(BreadStore breadStore)
        {
            Console.WriteLine("I bought some bread.");
        }

        public void visit(ClothStore clothStore)
        {
            Console.WriteLine("I bought some clothe.");
        }
    }
}
