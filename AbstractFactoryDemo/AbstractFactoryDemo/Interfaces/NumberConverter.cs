using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Interfaces
{
    interface NumberConverter
    {
        abstract string Convert(double number);
    }
}
