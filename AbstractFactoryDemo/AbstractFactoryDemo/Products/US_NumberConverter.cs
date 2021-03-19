using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractFactoryDemo.Products
{
    class US_NumberConverter : Interfaces.NumberConverter
    {
        public string Convert(double number)
        {
            return number.ToString(
                CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
