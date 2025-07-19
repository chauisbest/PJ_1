using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblDmNcc
    {
        public TblDmNcc()
        {
            TblXnkNhapKhos = new HashSet<TblXnkNhapKho>();
        }

        public int NccId { get; set; }
        public string MaNcc { get; set; } = null!;
        public string TenNcc { get; set; } = null!;
        public string? GhiChu { get; set; }

        public virtual ICollection<TblXnkNhapKho> TblXnkNhapKhos { get; set; }
    }
}
