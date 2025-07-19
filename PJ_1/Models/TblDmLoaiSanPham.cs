using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblDmLoaiSanPham
    {
        public TblDmLoaiSanPham()
        {
            TblDmSanPhams = new HashSet<TblDmSanPham>();
        }

        public int LoaiSanPhamId { get; set; }
        public string MaLsp { get; set; } = null!;
        public string TenLsp { get; set; } = null!;
        public string? GhiChu { get; set; }

        public virtual ICollection<TblDmSanPham> TblDmSanPhams { get; set; }
    }
}
