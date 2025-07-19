using System;
using System.Collections.Generic;

namespace PJ_1.Models
{
    public partial class TblDmKhoUser
    {
        public int KhoUserId { get; set; }
        public string MaDangNhap { get; set; } = null!;
        public int KhoId { get; set; }

        public virtual TblDmKho Kho { get; set; } = null!;
    }
}
