using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCShark
{
    abstract class SanPham 
    {
        public string ten { get; set; }
        public int dongia { get; set; }

        public SanPham(string tensp, int dongia)
        {
            this.ten = tensp;
            this.dongia = dongia;
        }

        public void printf()
        {
            System.Console.Write(ten + " " + dongia + " ");
        }
    }
}
