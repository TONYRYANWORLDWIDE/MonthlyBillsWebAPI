using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class ChimeRevenueByMonth
    {
        public double? Revenue { get; set; }
        public string MonthYear { get; set; }
    }
}
