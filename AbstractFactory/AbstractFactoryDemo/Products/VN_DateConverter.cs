using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractFactoryDemo.Products
{
    class VN_DateConverter : Interfaces.DateConverter
    {
        public string Convert(DateTime date)
        {
            return date.ToString(
                CultureInfo.CreateSpecificCulture("vi-VN"));
        }
    }
}
