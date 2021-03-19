using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Factory
{
    class VN_ConverterFactory : ConverterFactory
    {
        public DateConverter GetDateConverter()
        {
            return new VN_DateConverter();
        }

        public NumberConverter GetNumberConverter()
        {
            return new VN_NumberConverter();
        }
    }
}
