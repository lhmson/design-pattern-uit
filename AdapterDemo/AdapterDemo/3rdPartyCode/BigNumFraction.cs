using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo._3rdPartyCode
{
    class BigNumFraction
    {
        public BigNumFraction(string value)
        {
            var item = value.Split('/');
            if (item.Length != 2)
                throw new InvalidCastException();
            x = item[0];
            y = item[1];
            Reduce();
        }
        public string x;
        public string y;

        private void Reduce()
        {
            int a = int.Parse(x);
            int b = int.Parse(y);
            if (b < 0)
            {
                a = -a;
                b = -b;
            }
            int c = a;
            int d = b;
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            a = Math.Abs(a);
            x = (c / a).ToString();
            y = (d / a).ToString();
        }
        public BigNumFraction Add(BigNumFraction other)
        {
            int a = int.Parse(x);
            int b = int.Parse(y);
            int c = int.Parse(other.x);
            int d = int.Parse(other.y);
            {
                int x = a * d + b * c;
                int y = b * d;
                return new BigNumFraction(x.ToString() + '/' + y.ToString());
            }
        }
        public BigNumFraction Multiply(BigNumFraction other)
        {
            int a = int.Parse(x);
            int b = int.Parse(y);
            int c = int.Parse(other.x);
            int d = int.Parse(other.y);
            {
                int x = a * c;
                int y = b * d;
                return new BigNumFraction(x.ToString() + '/' + y.ToString());
            }
        }
        public void Negate()
        {
            if (x[0] == '-')
                x = x.Trim('-');
            else
                x = '-' + x;
        }
        public void Invert()
        {
            string t = x;
            x = y;
            y = t;
        }
    }

    class MyBigNumFraction : BigNumFraction
    {
        public MyBigNumFraction(string value) : base(value) { }

        public string Value() 
        {
            return (double.Parse(x) / int.Parse(y)).ToString(); 
        }
    }
}
