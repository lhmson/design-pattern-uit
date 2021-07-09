using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Originator_Calculator
    {
        public class Memento
        {
            private float value;
            private Originator_Calculator originator;

            public Memento(Originator_Calculator originator, float value) {
                this.value = value;
                this.originator = originator;
            }

            public void Restore()
            {
                originator.value = value;
                Console.WriteLine("Restored to " + value.ToString() + ".");
            }
        }
        private float value = 0;

        private void Print()
        {
            Console.WriteLine("= " + value.ToString());
        }

        public Memento Save()
        {
            return new Memento(this, value);
        }

        public void Add(float number)
        {
            value += number;
            Print();
        }
        public void Subtract(float number)
        {
            value -= number;
            Print();
        }
        public void Multiply(float number)
        {
            value *= number;
            Print();
        }
        public void Divide(float number)
        {
            value /= number;
            Print();
        }
    }
}
