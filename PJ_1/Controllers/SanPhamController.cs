using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PJ_1.Models;

namespace PJ_1.Controllers
{
    public class SanPhamController : Controller
    {
        DB_ThuctapContext dB = new DB_ThuctapContext();
        public IActionResult Index()
        {
            ViewBag.SanPham = dB.TblDmSanPhams
                .Include(x=>x.DonViTinh)
                .Include(x=>x.LoaiSanPham)
                .Where(x=>x.SanPhamId > 1)
                .ToList();
            return View("IndexSP");
        }
    }
}
