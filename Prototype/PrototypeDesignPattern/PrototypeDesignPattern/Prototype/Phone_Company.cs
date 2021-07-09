using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class Phone_Company : Company
    {
        public Phone_Company ShallowCopy()
        {
            return (Phone_Company)this.MemberwiseClone();
        }

        public Phone_Company DeepCopy()
        {
            Phone_Company clone = (Phone_Company)this.MemberwiseClone();
            clone.Info = new ProductInfo(Info.IdNumber,Info.Price);
            //clone.Name = String.Copy(Name);
            return clone;
        }

        public override Company Clone()
        {
            Phone_Company company = null;
            try
            {
                company = (Phone_Company)this.DeepCopy();
            }
            catch(NotSupportedException e)
            {
                Console.Write(e.Message);
            }
            return company;
        }
    }

}
