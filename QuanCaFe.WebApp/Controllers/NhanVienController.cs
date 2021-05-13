using Microsoft.AspNetCore.Mvc;
using QuanCaFe.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanCaFe.WebApp.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly QuanCaFeDBContext _context;
        public NhanVienController(QuanCaFeDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ListNhanVien = _context.NhanViens.ToList();
            return View(ListNhanVien);
        }
    }
}
