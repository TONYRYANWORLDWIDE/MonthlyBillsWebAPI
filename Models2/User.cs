using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class User
    {
        public User()
        {
            UserClaim = new HashSet<UserClaim>();
            UserLogin = new HashSet<UserLogin>();
            UserUserRole = new HashSet<UserUserRole>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
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

        public virtual ICollection<UserClaim> UserClaim { get; set; }
        public virtual ICollection<UserLogin> UserLogin { get; set; }
        public virtual ICollection<UserUserRole> UserUserRole { get; set; }
    }
}
