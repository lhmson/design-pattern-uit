using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context
            {
                Vocabulary = 's',
                Source = "sanh"
            };
            var expresion = new NonTerminalExpression();
            expresion.Interpret(context);
            Console.WriteLine(context.Result);
            Console.Read();
        }
    }
}
