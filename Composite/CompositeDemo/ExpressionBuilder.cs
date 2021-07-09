using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo
{
    class ExpressionBuilder
    {
        MathExpression expression = null;
        int balance = 0;

        public MathExpression GetExpression()
        {
            if (balance == 1)
                return expression;
            else
            {
                Console.WriteLine("Invalid expression: " + expression.ToString());
                return null;
            }
        }

        public void AddOperator()
        {
            if (balance >= 1 || expression == null)
                expression = new AddExpression(expression, null);
            else
                Insert(new AddExpression(null, null), expression);
                //expression.InsertLeftmost(new AddExpression(null, null));

            balance--;
        }

        public void MultiplyOperator()
        {
            if (balance >= 1 || expression == null)
                expression = new MultiplyExpression(expression, null);
            else
                Insert(new MultiplyExpression(null, null), expression);
                //expression.InsertLeftmost(new MultiplyExpression(null, null));

            balance--;
        }

        public void InsertValue(double value)
        {
            if (balance >= 1)
            {
                Console.WriteLine("Cannot accept more Values: " + expression.ToString() + " " + value.ToString());
                return;
            }

            if (expression == null)
                expression = (Value)value;
            else
            if (!Insert((Value)value, expression))
            //if (!expression.InsertLeftmost((Value)value))
            {
                Console.WriteLine("Unknown error: " + expression.ToString());
            }

            balance++;
        }

        static bool Insert(MathExpression expr, MathExpression current)
        {
            if (current is MathExpressionLeaf)
                return false;

            if (current.left == null)
            {
                current.left = expr;
                return true;
            }

            if (Insert(expr, current.left))
                return true;
            else
            {
                if (current.right == null)
                {
                    current.right = expr;
                    return true;
                }
                else
                    return Insert(expr, current.right);
            }
        }
    }
}
