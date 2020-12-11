using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class BringHomePayAll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Amount { get; set; }
        public string DayOfWeek { get; set; }
        public string Frequency { get; set; }
        public DateTime? PayDate { get; set; }
        public string UserId { get; set; }
    }
}
