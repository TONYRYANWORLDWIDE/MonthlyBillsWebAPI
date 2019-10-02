using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            BringHomePay = new HashSet<BringHomePay>();
            KeyBalance = new HashSet<KeyBalance>();
            MonthlyBills = new HashSet<MonthlyBills>();
            UpcomingBills = new HashSet<UpcomingBills>();
            WeeklyBills = new HashSet<WeeklyBills>();
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

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<BringHomePay> BringHomePay { get; set; }
        public virtual ICollection<KeyBalance> KeyBalance { get; set; }
        public virtual ICollection<MonthlyBills> MonthlyBills { get; set; }
        public virtual ICollection<UpcomingBills> UpcomingBills { get; set; }
        public virtual ICollection<WeeklyBills> WeeklyBills { get; set; }
    }
}
