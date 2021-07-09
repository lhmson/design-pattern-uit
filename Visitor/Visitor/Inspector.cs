using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Inspector : IPerson
    {
        public void visit(BreadStore breadStore)
        {
            Console.WriteLine("The bread in this store is: " + breadStore.BreadQuality());
        }

        public void visit(ClothStore clothStore)
        {
            Console.WriteLine("The clothe in this store is: " + clothStore.ClothQuality());
        }
    }
}
