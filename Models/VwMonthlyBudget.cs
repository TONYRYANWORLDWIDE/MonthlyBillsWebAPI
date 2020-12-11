using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class VwMonthlyBudget
    {
        public string Username { get; set; }
        public decimal? TotalOutflow { get; set; }
    }
}
