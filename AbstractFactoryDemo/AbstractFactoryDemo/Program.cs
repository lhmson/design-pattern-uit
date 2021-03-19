using AbstractFactoryDemo.Factory;
using AbstractFactoryDemo.Interfaces;
using System;
using System.Globalization;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterFactory converterFactory = new US_ConverterFactory();

            Console.WriteLine(converterFactory.GetDateConverter().Convert(
                DateTime.Now));

            Console.WriteLine(converterFactory.GetNumberConverter().Convert(
                Math.PI));
        }
    }
}
