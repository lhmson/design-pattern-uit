using AdapterDemo._3rdPartyCode;
using AdapterDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.ConcreteFraction
{
    class BigNumFractionClassAdapter : BigNumFraction, Fraction
    {
        public BigNumFractionClassAdapter(string value) : base(value) { }
        private static BigNumFraction toBigNumFraction(Fraction f)
        {
            return new BigNumFraction(f.GetNumerator().ToString() + "/" + f.GetDenumerator().ToString());
        }
        private static BigNumFractionClassAdapter toBigNumFractionClassAdapter(BigNumFraction f)
        {
            return new BigNumFractionClassAdapter(f.x + "/" + f.y);
        }
        public Fraction Add(Fraction other)
        {
            return toBigNumFractionClassAdapter(base.Add(toBigNumFraction(other)));
        }

        public Fraction Divide(Fraction other)
        {
            var temp = toBigNumFraction(other);
            temp.Invert();
            return toBigNumFractionClassAdapter(Multiply(temp));
        }

        public int GetDenumerator()
        {
            return int.Parse(y);
        }

        public int GetNumerator()
        {
            return int.Parse(x);
        }

        public Fraction Multiply(Fraction other)
        {
            return toBigNumFractionClassAdapter(base.Multiply(toBigNumFraction(other)));
        }

        public Fraction Subtract(Fraction other)
        {
            var temp = toBigNumFraction(other);
            temp.Negate();
            return toBigNumFractionClassAdapter(Add(temp));
        }
    }
}
