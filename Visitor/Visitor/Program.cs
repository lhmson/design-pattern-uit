using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerWantBread();
            CustomerWantClothe();
            InspectorCheckBread();
            InspectorCheckClothe();
        }

        static void CustomerWantBread()
        {
            IPerson person = new Customer();
            IStore store = new BreadStore();

            store.accept(person);
        }
        static void CustomerWantClothe()
        {
            IPerson person = new Customer();
            IStore store = new ClothStore();

            store.accept(person);
        }
        static void InspectorCheckBread()
        {
            IPerson person = new Inspector();
            IStore store = new BreadStore();

            store.accept(person);
        }
        static void InspectorCheckClothe()
        {
            IPerson person = new Inspector();
            IStore store = new ClothStore();

            store.accept(person);
        }
    }
}
