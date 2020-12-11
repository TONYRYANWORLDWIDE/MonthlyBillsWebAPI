using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class DisasterInfo
    {
        public int DisasterNumber { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public DateTime RefreshAdj { get; set; }
        public DateTime DeclarationDate { get; set; }
        public DateTime? LastRefresh { get; set; }
    }
}
