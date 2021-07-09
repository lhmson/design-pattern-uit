using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            string line;
            while ((line = Console.ReadLine()) != "exit")
            {
                caretaker.AddCalculation(line);
            }
        }
    }
}
