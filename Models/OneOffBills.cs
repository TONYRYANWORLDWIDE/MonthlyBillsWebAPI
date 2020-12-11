using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class OneOffBills
    {
        public int Id { get; set; }
        public string Bill { get; set; }
        public float Cost { get; set; }
        public DateTime Date { get; set; }
        public int TypeId { get; set; }
        public string UserId { get; set; }

        public virtual BillTypes Type { get; set; }
    }
}
