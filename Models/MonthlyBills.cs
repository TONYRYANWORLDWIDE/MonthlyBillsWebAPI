using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class MonthlyBills
    {
        public int Id { get; set; }
        public string Bill { get; set; }
        public float? Cost { get; set; }
        public int? Date { get; set; }
        public string BillAlias { get; set; }
        public string UserId { get; set; }
        public bool? Paid { get; set; }
    }
}
