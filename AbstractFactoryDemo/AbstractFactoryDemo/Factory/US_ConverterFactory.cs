using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Factory
{
    class US_ConverterFactory : ConverterFactory
    {
        public DateConverter GetDateConverter()
        {
            return new US_DateConverter();
        }

        public NumberConverter GetNumberConverter()
        {
            return new US_NumberConverter();
        }
    }
}
