using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo
{
    class Value : MathExpressionLeaf
    {
        double value;
        public Value(double value) { this.value = value; }
        public static implicit operator double(Value value) => value.value;
        public static implicit operator Value(double value) => new Value(value);
        public override double Evaluate()
        {
            return value;
        }

        public override string ToString()
        {
            return ((double)this).ToString();
        }
    }
}
