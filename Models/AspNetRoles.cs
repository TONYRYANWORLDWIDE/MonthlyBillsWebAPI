using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetUserRoles1 = new HashSet<AspNetUserRoles1>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUserRoles1> AspNetUserRoles1 { get; set; }
    }
}
