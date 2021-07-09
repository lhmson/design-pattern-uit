using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class BreadOrder : ICompletable, IPublishComplete
    {
        private Customer customer;

        public List<ICompletable> listeners = new List<ICompletable>();
        public IEnumerable<ICompletable> observers
        {
            get => listeners;
            set => listeners = value.ToList();
        }
        
        public Customer Customer { set => customer = value; }

        public void Done()
        {
            ClearTable();
        }

        public void Order()
        {
            Console.WriteLine("The store is cooking bread");
            Task.Delay(2000).ContinueWith(task =>
            {
                customer.Subscribe(this);
                this.notifyComplete();
            });
        }

        public void ClearTable()
        {
            Console.WriteLine("The customer has left. Cleaning up the table.");
        }
    }
}
