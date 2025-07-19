using Microsoft.AspNetCore.Mvc;
using PJ_1.Models;

namespace PJ_1.Controllers
{
    public class DonViController : Controller
    {
        DB_ThuctapContext db = new DB_ThuctapContext();
        public IActionResult Index()
        {
            ViewBag.DS_DonViTinh = db.TblDmDonViTinhs
                .Where(x => x.DonViTinhId > 1)
                .ToList();
            return View();
        }
        public IActionResult Create(TblDmDonViTinh dvt)
        {
            db.TblDmDonViTinhs.Add(dvt);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var dvt = db.TblDmDonViTinhs.FirstOrDefault(x => x.DonViTinhId == id);
            if(dvt==null)
                return NotFound();
            else
            {
                db.TblDmDonViTinhs.Remove(dvt);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var dvt = db.TblDmDonViTinhs.FirstOrDefault(x => x.DonViTinhId == id);
            if (dvt == null)
            {
                return NotFound();
            }
            else
            {
                return View(dvt);
            }
        }
        [HttpPost]
        public IActionResult Update(TblDmDonViTinh dvt)
        {
            db.TblDmDonViTinhs.Update(dvt);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
