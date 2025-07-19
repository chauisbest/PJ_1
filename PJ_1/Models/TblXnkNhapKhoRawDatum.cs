using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblXnkNhapKhoRawDatum
    {
        public int NhapKhoId { get; set; }
        public int SanPhamId { get; set; }
        public int SlNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public int PhieuNhapKhoId { get; set; }

        public virtual TblXnkNhapKho PhieuNhapKho { get; set; } = null!;
        public virtual TblDmSanPham SanPham { get; set; } = null!;
    }
}
