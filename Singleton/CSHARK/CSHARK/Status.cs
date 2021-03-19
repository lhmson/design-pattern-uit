using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARK
{
    internal partial class DBConnection
    {
        private enum Status
        {
            Busy, Open, Close
        }
    }
}
