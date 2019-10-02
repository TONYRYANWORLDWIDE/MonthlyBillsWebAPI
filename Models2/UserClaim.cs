using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class UserClaim
    {
        public int UserId { get; set; }
        public int ClaimId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual User User { get; set; }
    }
}
