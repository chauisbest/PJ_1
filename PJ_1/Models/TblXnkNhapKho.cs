using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblXnkNhapKho
    {
        public TblXnkNhapKho()
        {
            TblXnkNhapKhoRawData = new HashSet<TblXnkNhapKhoRawDatum>();
        }

        public int PhieuNhapKhoId { get; set; }
        public string SoPhieuNhapKho { get; set; } = null!;
        public int KhoId { get; set; }
        public int NccId { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public string? GhiChu { get; set; }

        public virtual TblDmKho Kho { get; set; } = null!;
        public virtual TblDmNcc Ncc { get; set; } = null!;
        public virtual ICollection<TblXnkNhapKhoRawDatum> TblXnkNhapKhoRawData { get; set; }
    }
}
