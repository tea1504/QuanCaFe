using QuanCaFe.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Entities
{
    public class HoaDon
    {
        public int Id { get; set; }
        public DateTime Ngaygio { get; set; }
        public ThanhToan Dathanhtoan { get; set; }
        public int Soban{ get; set; }
        public int MSNV { get; set; }
    }
}
