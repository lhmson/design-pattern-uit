using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Products
{
    class US_DateConverter : DateConverter
    {
        public string Convert(DateTime date)
        {
            return date.ToString(
                CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
