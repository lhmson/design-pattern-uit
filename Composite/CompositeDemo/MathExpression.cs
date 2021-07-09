using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo
{
    abstract class MathExpression
    {
        public MathExpression left;
        public MathExpression right;
        public abstract double Evaluate();
        public override abstract string ToString();
        public abstract bool InsertLeftmost(MathExpression expr);
    }
    abstract class MathExpressionLeaf : MathExpression 
    {
        public override bool InsertLeftmost(MathExpression expr)
        {
            return false;
        }
    }
    abstract class MathExpressionComposite : MathExpression {
        public override bool InsertLeftmost(MathExpression expr)
        {
            if (left == null)
            {
                left = expr;
                return true;
            }
            if (left.InsertLeftmost(expr))
                return true;
            else
            {
                if (right == null)
                {
                    right = expr;
                    return true;
                }
                else
                    return right.InsertLeftmost(expr);
            }
        }
    }
}
