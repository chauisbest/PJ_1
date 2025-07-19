using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblDmSanPham
    {
        public TblDmSanPham()
        {
            TblXnkNhapKhoRawData = new HashSet<TblXnkNhapKhoRawDatum>();
            TblXnkXuatKhoRawData = new HashSet<TblXnkXuatKhoRawDatum>();
        }

        public int SanPhamId { get; set; }
        public string MaSanPham { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public int LoaiSanPhamId { get; set; }
        public int DonViTinhId { get; set; }
        public string? GhiChu { get; set; }

        public virtual TblDmDonViTinh DonViTinh { get; set; } = null!;
        public virtual TblDmLoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual ICollection<TblXnkNhapKhoRawDatum> TblXnkNhapKhoRawData { get; set; }
        public virtual ICollection<TblXnkXuatKhoRawDatum> TblXnkXuatKhoRawData { get; set; }
    }
}
