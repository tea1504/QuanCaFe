using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Entities
{
    public class HoaDonChiTiet
    {
        public int MSTU { get; set; }
        public int Soluong { get; set; }
        public float Giaban { get; set; }
        public int SoHD { get; set; }
        public HoaDon HoaDon { get; set; }
        public ThucUong ThucUong { get; set; }
    }
}
