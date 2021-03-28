using System;
using System.Collections.Generic;
using System.Text;
using AdapterDemo.Interface;

namespace AdapterDemo.ConcreteFraction
{
    class NaiveFraction : Fraction
    {
        protected int x;
        protected int y;
        // the value is x/y

        public NaiveFraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Fraction Add(Fraction other)
        {
            return new NaiveFraction(x * other.GetDenumerator() + y * other.GetNumerator(), other.GetDenumerator() * y);
        }

        public Fraction Divide(Fraction other)
        {
            return new NaiveFraction(x * other.GetDenumerator(), y * other.GetNumerator());
        }

        public int GetDenumerator()
        {
            return y;
        }

        public int GetNumerator()
        {
            return x;
        }

        public Fraction Multiply(Fraction other)
        {
            return new NaiveFraction(x * other.GetNumerator(), y * other.GetDenumerator());
        }

        public Fraction Subtract(Fraction other)
        {
            return new NaiveFraction(x * other.GetDenumerator() - y * other.GetNumerator(), other.GetDenumerator() * y);
        }
    }
}
