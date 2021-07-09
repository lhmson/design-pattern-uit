using System;

namespace CompositeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionBuilder builder = new ExpressionBuilder();

            // (1 + 3) * (2 + 1.5 * 2)
            builder.MultiplyOperator();
                builder.AddOperator();
                    builder.InsertValue(1);
                    builder.InsertValue(3);
                builder.AddOperator();
                    builder.InsertValue(2);
                    builder.MultiplyOperator();
                        builder.InsertValue(1.5);
                        builder.InsertValue(2);

            MathExpression expr = builder.GetExpression();

            if (expr != null)
            {
                Console.WriteLine(expr.ToString());
                Console.WriteLine(expr.Evaluate());
            }
        }
    }
}
