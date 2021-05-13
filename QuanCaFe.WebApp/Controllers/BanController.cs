using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanCaFe.Data.EF;
using QuanCaFe.Data.Entities;
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
            //TH2 cmt
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bans.ToListAsync());
        }
        public IActionResult Create()
        {
            ViewBag.id = _context.Bans.Count() + 1;
            return View();
        }
        [HttpPost, ActionName("Create")]
        public IActionResult Create(Ban b)
        {
            try
            {
                _context.Bans.Add(b);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                ViewBag.Err = "Lỗi lưu dữ liệu";
                return View("Create", b);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            Ban b = _context.Bans.Find(id);
            return View(b);
        }
        //TH4 cmt
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var banToUpdate = await _context.Bans.SingleOrDefaultAsync(b => b.Id == id);
            try
            {
                if (await TryUpdateModelAsync<Ban>(banToUpdate, "", b=>b.Mota))
                {
                    _context.Entry(banToUpdate).State = EntityState.Modified;
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                ViewBag.Err = "Lỗi lưu dữ liệu";
                return View("Edit", banToUpdate);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Ban b = _context.Bans.SingleOrDefault(b => b.Id == id);
            _context.Remove(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
