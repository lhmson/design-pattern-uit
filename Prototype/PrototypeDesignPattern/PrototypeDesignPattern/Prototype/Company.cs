using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public abstract class Company
    {
        public int Rating;
        public string Name;
        public ProductInfo Info;
        public abstract Company Clone();
    }

    public class ProductInfo
    {
        public int IdNumber;
        public int Price;

        public ProductInfo(int idNumber, int price)
        {
            this.IdNumber = idNumber;
            this.Price = price;
        }
    }
}
