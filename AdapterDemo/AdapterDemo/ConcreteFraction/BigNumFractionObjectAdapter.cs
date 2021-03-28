using AdapterDemo._3rdPartyCode;
using AdapterDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.ConcreteFraction
{
    class BigNumFractionObjectAdapter : Fraction
    {
        protected BigNumFraction fraction;
        public BigNumFractionObjectAdapter(string value) { fraction = new BigNumFraction(value); }
        private static BigNumFraction toBigNumFraction(Fraction f)
        // Helper function
        {
            return new BigNumFraction(f.GetNumerator().ToString() + "/" + f.GetDenumerator().ToString());
        }
        private static NaiveFraction toNaiveFraction(BigNumFraction f)
        // Helper function
        {
            return new NaiveFraction(int.Parse(f.x), int.Parse(f.y));
        }
        public Fraction Add(Fraction other)
        {
            return toNaiveFraction(fraction.Add(toBigNumFraction(other)));
        }

        public Fraction Divide(Fraction other)
        {
            var temp = toBigNumFraction(other);
            temp.Invert();
            return toNaiveFraction(fraction.Multiply(temp));
        }

        public int GetDenumerator()
        {
            return int.Parse(fraction.y);
        }

        public int GetNumerator()
        {
            return int.Parse(fraction.x);
        }

        public Fraction Multiply(Fraction other)
        {
            return toNaiveFraction(fraction.Multiply(toBigNumFraction(other)));
        }

        public Fraction Subtract(Fraction other)
        {
            var temp = toBigNumFraction(other);
            temp.Negate();
            return toNaiveFraction(fraction.Add(temp));
        }
    }
}
