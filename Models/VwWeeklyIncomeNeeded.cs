using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class VwWeeklyIncomeNeeded
    {
        public DateTime? TheDate { get; set; }
        public string DayOfWeek { get; set; }
        public decimal? RunningTotal { get; set; }
        public int? WeeksTillMaxNeg { get; set; }
        public decimal? NeededPerWeek { get; set; }
    }
}
