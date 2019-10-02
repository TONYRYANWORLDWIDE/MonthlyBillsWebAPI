using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class UserRole
    {
        public UserRole()
        {
            UserUserRole = new HashSet<UserUserRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserUserRole> UserUserRole { get; set; }
    }
}
