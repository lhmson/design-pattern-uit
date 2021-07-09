using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo
{
    class MultiplyExpression : MathExpressionComposite
    {
        public MultiplyExpression(MathExpression left, MathExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public override double Evaluate()
        {
            return left.Evaluate() * right.Evaluate();
        }

        public override string ToString()
        {
            return (left?.ToString() ?? "") + " * " + (right?.ToString() ?? "");
        }
    }
}
