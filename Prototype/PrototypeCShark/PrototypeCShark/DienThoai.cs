using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCShark
{
    class DienThoai : SanPham, ICloneable
    {
        public string hangsx { get; set; }
        public DienThoai(string tensp, int dongia, string hangsx) : base(tensp, dongia)
        {
            this.hangsx = hangsx;
        }

        public object Clone()
        {
            return this.MemberwiseClone(); //Deepcopy
        }


        public void printf()
        {
            base.printf();
            System.Console.WriteLine(hangsx);
        }
    }
}
