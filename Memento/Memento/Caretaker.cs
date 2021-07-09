using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Caretaker
    {
        Originator_Calculator calculator = new Originator_Calculator();
        List<Originator_Calculator.Memento> history = new List<Originator_Calculator.Memento>();

        string _operator = "+";

        public void AddCalculation(string s)
        {
            string[] words = s.Split();
            foreach (string word in words)
            {
                if (word == "undo")
                {
                    Undo();
                    continue;
                }

                if (_operator == null && ValidOperator(word))
                {
                    _operator = word;
                    continue;
                }

                float value;
                bool isFloat = float.TryParse(word, out value);

                if (_operator != null && isFloat)
                {
                    PerformOperation(_operator, value);
                }
            }
        }

        bool ValidOperator(string operation)
        {
            return Operation(operation, 0) != null;
        }
        void PerformOperation(string operation, float number)
        {
            history.Add(calculator.Save());

            Operation(_operator, number).Invoke();

            _operator = null;
        }
        Action Operation(string operation, float number)
        {
            switch (operation)
            {
                case "+":
                    return () => calculator.Add(number);
                case "-":
                    return () => calculator.Subtract(number);
                case "*":
                    return () => calculator.Multiply(number);
                case "/":
                    return () => calculator.Divide(number);
                case "goto":
                    return () => GotoX_Step((int)(number));
                default:
                    return null;
            }
        }

        public void Undo()
        {
            if (history.Count <= 0)
            {
                Console.WriteLine("There is nothing to undo.");
                return;
            }
            // pop
            var item = history[history.Count - 1];
            history.RemoveAt(history.Count - 1);

            item.Restore();

            Console.WriteLine("Undo complete.");
        }
        public void GotoX_Step(int x)
        {
            if (history.Count < x)
            {
                Console.WriteLine("There isn't enough steps to goto");
                return;
            }
            
            if (x <= 0)
            {
                Console.WriteLine("Invalid step.");
                Console.WriteLine("Steps are numbered 1..n.");
            }

            var item = history[x - 1];
            history.RemoveRange(x - 1, history.Count - x + 1);

            item.Restore();
        }
    }
}
