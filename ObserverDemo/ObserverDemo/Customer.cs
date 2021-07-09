using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class Customer : ICompletable, IPublishComplete
    {
        public List<ICompletable> listeners = new List<ICompletable>();
        public IEnumerable<ICompletable> observers 
        { 
            get => listeners;
            set => listeners = value.ToList(); 
        }

        public void Done()
        {
            Console.WriteLine("The customer has recieved bread.");
            Task.Delay(2000).ContinueWith(task => this.notifyComplete());
        }

        public BreadOrder Order()
        {
            BreadOrder order = new BreadOrder();
            order.Customer = this;

            order.Subscribe(this);
            order.Order();

            return order;
        }
    }
}
