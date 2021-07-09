using System;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Order();

            Task.Delay(5000).Wait();
        }
    }
}
