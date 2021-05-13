using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanCaFe.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanCaFe.WebApp.Controllers
{
    public class BanController : Controller
    {
        private readonly QuanCaFeDBContext _context;
        public BanController(QuanCaFeDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bans.ToListAsync());
        }
    }
}
