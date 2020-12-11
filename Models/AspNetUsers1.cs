using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class AspNetUsers1
    {
        public AspNetUsers1()
        {
            AspNetUserClaims1 = new HashSet<AspNetUserClaims1>();
            AspNetUserLogins1 = new HashSet<AspNetUserLogins1>();
            AspNetUserRoles1 = new HashSet<AspNetUserRoles1>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<AspNetUserClaims1> AspNetUserClaims1 { get; set; }
        public virtual ICollection<AspNetUserLogins1> AspNetUserLogins1 { get; set; }
        public virtual ICollection<AspNetUserRoles1> AspNetUserRoles1 { get; set; }
    }
}
