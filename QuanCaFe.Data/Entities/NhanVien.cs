using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Entities
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }
}
