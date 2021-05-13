using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Entities
{
    public class ThucUong
    {
        public int Id { get; set; }
        public string TenTU { get; set; }
        public float GiaTU { get; set; }
        public List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
