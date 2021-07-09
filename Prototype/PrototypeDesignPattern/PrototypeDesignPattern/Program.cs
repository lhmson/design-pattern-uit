using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone_Company company1 = new Phone_Company();
            company1.Rating = 5;
            company1.Name = "Apple";
            company1.Info = new ProductInfo(10, 1000);

            // Perform a shallow copy of company1 and assign it to company2.
            Phone_Company company2 = company1.ShallowCopy();
            company2.Name = "Oppo";
            // Make a deep copy of company1 and assign it to company3.
            Phone_Company company3 = company1.DeepCopy();
            company3.Name = "Samsung";

            /*
            //use copy constructor
            Phone_Company company_super = new Phone_Company();
            company_super = company1.DeepCopy();
            /*/

            //use prototype
            var company_super = company1.Clone();
            //*/

            // Display values of company1, company2 and company3.
            Console.WriteLine("Original values of company1, company2, company3:");
            Console.WriteLine("   company1 instance values: ");
            DisplayValues(company1);
            Console.WriteLine("   company2 instance values:");
            DisplayValues(company2);
            Console.WriteLine("   company3 instance values:");
            DisplayValues(company3);
            Console.WriteLine("   companysuper instance values:");
            DisplayValues(company_super);

            Console.WriteLine("Super Company being changed");
            company_super.Name = "LS company";
            company_super.Rating = 16;
            company_super.Info.IdNumber = 200;
            company_super.Info.Price = 2000;

            // Change the value of company1 properties and display the values of company1,
            // company2 and company3.
            company1.Rating = 12;
            company1.Info.IdNumber = 150;
            company1.Info.Price = 1500;
            Console.WriteLine("\nValues of company1, company2 and company3 after changes to company1:");
            Console.WriteLine("   company1 instance values: ");
            DisplayValues(company1);
            Console.WriteLine("   company2 instance values (reference values have changed):");
            DisplayValues(company2);
            Console.WriteLine("   company3 instance values (everything was kept the same):");
            DisplayValues(company3);
            Console.WriteLine("   companysuper instance values:");
            DisplayValues(company_super);
        }

        public static void DisplayValues(Company p)
        {
            Console.WriteLine("      Name: {0:s}, Rating: {1:d}",
                p.Name, p.Rating);
            Console.WriteLine("      ID: {0:d}, Price: {1:d}", p.Info.IdNumber, p.Info.Price);
        }
    }
}
