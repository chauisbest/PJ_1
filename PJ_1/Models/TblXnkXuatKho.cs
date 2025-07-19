using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblXnkXuatKho
    {
        public TblXnkXuatKho()
        {
            TblXnkXuatKhoRawData = new HashSet<TblXnkXuatKhoRawDatum>();
        }

        public int PhieuXuatKhoId { get; set; }
        public string SoPhieuXuatKho { get; set; } = null!;
        public int KhoId { get; set; }
        public DateTime NgayXuatKho { get; set; }
        public string? GhiChu { get; set; }

        public virtual TblDmKho Kho { get; set; } = null!;
        public virtual ICollection<TblXnkXuatKhoRawDatum> TblXnkXuatKhoRawData { get; set; }
    }
}
