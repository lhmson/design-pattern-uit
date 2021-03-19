using System;

namespace CSHARK
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var db = DBConnection.GetInstance();
                db.Fill();
                db.End();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}
