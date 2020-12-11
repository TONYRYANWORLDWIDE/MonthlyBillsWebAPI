using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class Calories
    {
        public DateTime? Creationdate { get; set; }
        public decimal? Restingenergy { get; set; }
        public decimal? Activeenergy { get; set; }
        public decimal? Totalburned { get; set; }
    }
}
