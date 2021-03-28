using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Interface
{
    interface Fraction
    {
        Fraction Add(Fraction other);
        Fraction Subtract(Fraction other);
        Fraction Multiply(Fraction other);
        Fraction Divide(Fraction other);
        int GetNumerator();
        int GetDenumerator();
    }
}
