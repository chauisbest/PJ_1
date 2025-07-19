using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblXnkXuatKhoRawDatum
    {
        public int XuatKhoId { get; set; }
        public int SanPhamId { get; set; }
        public int SlXuat { get; set; }
        public decimal DonGiaXuat { get; set; }
        public int PhieuXuatKhoId { get; set; }

        public virtual TblXnkXuatKho PhieuXuatKho { get; set; } = null!;
        public virtual TblDmSanPham SanPham { get; set; } = null!;
    }
}
