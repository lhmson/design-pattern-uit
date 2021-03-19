using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractFactoryDemo.Products
{
    class VN_NumberConverter : NumberConverter
    {
        public string Convert(double number)
        {
            return number.ToString(
                CultureInfo.CreateSpecificCulture("vi-VN"));
        }
    }
}
