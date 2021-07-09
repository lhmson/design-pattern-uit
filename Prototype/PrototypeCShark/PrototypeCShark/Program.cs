using System;

namespace PrototypeCShark
{
    class Program
    {
        static void Main(string[] args)
        {
            DienThoai dtA = new DienThoai("iPhone11", 20000000, "Apple");
            DienThoai dtB = dtA.Clone() as DienThoai;

            dtB.ten = "iPhone11Promax";

            Console.WriteLine("Dien thoai A");
            dtA.printf();

            Console.WriteLine("Dien thoai B");
            dtB.printf();

            Console.ReadLine();
        }
    }
}
