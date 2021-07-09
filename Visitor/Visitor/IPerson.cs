using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IPerson
    {
        public void visit(BreadStore breadStore);
        public void visit(ClothStore clothStore);
    }
}
