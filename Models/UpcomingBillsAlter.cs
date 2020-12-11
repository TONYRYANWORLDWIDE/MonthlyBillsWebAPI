using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class UpcomingBillsAlter
    {
        public int Id { get; set; }
        public DateTime? TheDate { get; set; }
        public string DayOfWeek { get; set; }
        public string Name { get; set; }
        public float? Amount { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public bool? Paid { get; set; }
    }
}
