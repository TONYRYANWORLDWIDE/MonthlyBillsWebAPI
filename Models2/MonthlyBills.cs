using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class MonthlyBills
    {
        public int Id { get; set; }
        public string Bill { get; set; }
        public float? Cost { get; set; }
        public string Date { get; set; }
        public string BillAlias { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
