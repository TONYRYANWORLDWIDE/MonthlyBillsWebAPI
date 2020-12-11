using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class WeeklyBills
    {
        public int Id { get; set; }
        public string Bill { get; set; }
        public float? Cost { get; set; }
        public string DayOfWeek { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
