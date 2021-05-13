using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanCaFe.Data.Entities
{
    public class Ban
    {
        [Required(ErrorMessage = "Bạn phải nhập số bàn")]
        [Display(Name = "Số bàn")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string? Mota { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }
}
