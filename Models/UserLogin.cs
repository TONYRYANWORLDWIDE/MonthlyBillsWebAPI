using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class UserLogin
    {
        public int UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }

        public virtual User User { get; set; }
    }
}
