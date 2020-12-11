using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class Dates
    {
        public int Id { get; set; }
        public DateTime? Thedate { get; set; }
        public int? Day { get; set; }
        public string DayOfWeek { get; set; }
        public string DayOfMonth { get; set; }
    }
}
