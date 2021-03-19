using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Interfaces
{
    interface DateConverter
    {
        abstract string Convert(DateTime date);
    }
}
