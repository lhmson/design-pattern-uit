using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARK
{
    internal partial class DBConnection
    {
        private static readonly Lazy<DBConnection> _singleton = new Lazy<DBConnection>(() => new DBConnection());

        public static DBConnection GetInstance() => _singleton.Value;

        private Status _status;

        private DBConnection()
        {
            Console.WriteLine("Starting");
            _status = Status.Open;
        }

        public void Fill()
        {
            if (!IsOpen) return;
            Console.WriteLine("Filling...");
            _status = Status.Busy;
        }

        public void End()
        {
            if (!IsBusy) return;
            Console.WriteLine("Closed...");
            _status = Status.Close;
        }

        private bool IsOpen => (_status == Status.Open);

        private bool IsBusy => (_status == Status.Busy);
    }
}
