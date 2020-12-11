using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class AspNetUserClaims1
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUsers1 User { get; set; }
    }
}
