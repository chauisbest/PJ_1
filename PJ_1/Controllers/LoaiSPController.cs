﻿using Microsoft.AspNetCore.Mvc;
using PJ_1.Models;

namespace PJ_1.Controllers
{
    public class LoaiSPController : Controller
    {
        DB_ThuctapContext db = new DB_ThuctapContext();
        public IActionResult Index()
        {
            ViewBag.LoaiSP = db.TblDmLoaiSanPhams
                .Where(x => x.LoaiSanPhamId > 1)
                .ToList();
            return View();
        }
        public IActionResult Create(TblDmLoaiSanPham sp)
        {
            db.TblDmLoaiSanPhams.Add(sp);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var lsp = db.TblDmLoaiSanPhams.FirstOrDefault(x=>x.LoaiSanPhamId == id);
            if (lsp == null)
            {
                return NotFound();
            }
            else
            {
                db.TblDmLoaiSanPhams.Remove(lsp);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var lsp = db.TblDmLoaiSanPhams.FirstOrDefault(x=>x.LoaiSanPhamId==id);
            if (lsp == null)
            {
                return NotFound();
            }
            else
            {
                return View("UpdateLoaiSP", lsp);
            }
        }
        [HttpPost]
        public IActionResult Update (TblDmLoaiSanPham sp)
        {
            db.TblDmLoaiSanPhams.Update(sp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
