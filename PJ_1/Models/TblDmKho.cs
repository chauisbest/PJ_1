using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblDmKho
    {
        public TblDmKho()
        {
            TblDmKhoUsers = new HashSet<TblDmKhoUser>();
            TblXnkNhapKhos = new HashSet<TblXnkNhapKho>();
            TblXnkXuatKhos = new HashSet<TblXnkXuatKho>();
        }

        public int KhoId { get; set; }
        public string TenKho { get; set; } = null!;
        public string? GhiChu { get; set; }

        public virtual ICollection<TblDmKhoUser> TblDmKhoUsers { get; set; }
        public virtual ICollection<TblXnkNhapKho> TblXnkNhapKhos { get; set; }
        public virtual ICollection<TblXnkXuatKho> TblXnkXuatKhos { get; set; }
    }
}
