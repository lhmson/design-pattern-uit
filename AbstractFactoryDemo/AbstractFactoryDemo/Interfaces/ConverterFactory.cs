using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Interfaces
{
    interface ConverterFactory
    {
        abstract DateConverter GetDateConverter();
        abstract NumberConverter GetNumberConverter();
    }
}
