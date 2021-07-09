using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ObserverDemo
{
    public interface IPublishComplete
    {
        IEnumerable<ICompletable> observers { get; set; }
    }
    public static partial class Extention
    {
        public static void Subscribe(this IPublishComplete publisher, ICompletable listener)
        {
            publisher.observers = publisher.observers.Append(listener);
        }
        public static void Unsubscribe(this IPublishComplete publisher, ICompletable listener)
        {
            publisher.observers = publisher.observers.Where(item => item == listener);
        }
        public static void notifyComplete(this IPublishComplete publisher)
        {
            List<ICompletable> list = publisher.observers.ToList();
            foreach (var item in list)
            {
                item.Done();
            }
        }
    }
}
