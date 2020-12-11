using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles2 Role { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
