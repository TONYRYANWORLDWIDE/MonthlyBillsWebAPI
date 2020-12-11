using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class AspNetUserLogins1
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers1 User { get; set; }
    }
}
