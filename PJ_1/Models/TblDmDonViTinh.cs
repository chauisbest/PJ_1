using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PJ_1.Models
{
    public partial class TblDmDonViTinh
    {
        public TblDmDonViTinh()
        {
            TblDmSanPhams = new HashSet<TblDmSanPham>();
        }
        [Display (Name = "Ma don vi tinh")]
        public int DonViTinhId { get; set; }
        [Display(Name ="Ten don vi tinh")]
        public string TenDonViTinh { get; set; } = null!;
        [Display(Name ="Ghi chu")]
        public string? GhiChu { get; set; }

        public virtual ICollection<TblDmSanPham> TblDmSanPhams { get; set; }
    }
}
