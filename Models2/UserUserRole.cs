using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class UserUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual UserRole Role { get; set; }
        public virtual User User { get; set; }
    }
}
