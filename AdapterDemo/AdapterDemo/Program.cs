
using AdapterDemo._3rdPartyCode;
using AdapterDemo.ConcreteFraction;
using AdapterDemo.Interface;
using System;

namespace AdapterDemo
{
    class Program
    {
        static void PrintFraction(Fraction f)
        {
            Console.WriteLine(f.GetNumerator().ToString() + "/" + f.GetDenumerator().ToString());
        }
        static void Client1()
        {
            //Fraction f1 = new NaiveFraction(1, 2);
            //Fraction f2 = new NaiveFraction(1, 3);
            Fraction f1 = new BigNumFractionObjectAdapter("1/2");
            Fraction f2 = new BigNumFractionObjectAdapter("1/3");
            Fraction f3 = f1.Add(f2);
            Fraction f4 = f1.Subtract(f2);
            Fraction f5 = f1.Multiply(f2);
            Fraction f6 = f1.Divide(f2);

            PrintFraction(f3);
            PrintFraction(f4);
            PrintFraction(f5);
            PrintFraction(f6);
        }
        static void Client2()
        {
            //Fraction f1 = new NaiveFraction(1, 2);
            //Fraction f2 = new NaiveFraction(1, 3);
            Fraction f1 = new BigNumFractionClassAdapter("1/2");
            Fraction f2 = new BigNumFractionClassAdapter("1/3");
            Fraction f3 = f1.Add(f2);
            Fraction f4 = f1.Subtract(f2);
            Fraction f5 = f1.Multiply(f2);
            Fraction f6 = f1.Divide(f2);

            PrintFraction(f3);
            PrintFraction(f4);
            PrintFraction(f5);
            PrintFraction(f6);
        }
        static void Client3(BigNumFraction f1)
        {
            f1.Negate();
        }
        static void Client4(Fraction f1)
        {
            PrintFraction(f1);

            Fraction f2 = new BigNumFractionClassAdapter("1/2");
            Fraction f3 = f1.Add(f2);

            PrintFraction(f3);
        }
        static void Main(string[] args)
        {
            //Client1();
            //Client2();
            //*
            BigNumFractionClassAdapter f = new BigNumFractionClassAdapter("1/3");
            Client3(f);
            Client4(f);
            // */
        }
    }
}
