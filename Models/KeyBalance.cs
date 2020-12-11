using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class KeyBalance
    {
        public int Id { get; set; }
        public float? KeyBalance1 { get; set; }
        public DateTime? DateTime { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
