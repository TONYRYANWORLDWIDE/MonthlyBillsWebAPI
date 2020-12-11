using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class UpcomingBills
    {
        public int Id { get; set; }
        public DateTime? TheDate { get; set; }
        public string DayOfWeek { get; set; }
        public string Name { get; set; }
        public float? Amount { get; set; }
        public string Type { get; set; }
        public decimal? RunningTotal { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
