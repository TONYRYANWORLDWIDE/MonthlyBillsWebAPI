using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models2
{
    public partial class TransactionsupdateNew
    {
        public int Id { get; set; }
        public long Index { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Originaldescription { get; set; }
        public double? Amount { get; set; }
        public string AmountTransformed { get; set; }
        public string TransactionType { get; set; }
        public string Category { get; set; }
        public string AccountName { get; set; }
        public string SubCat { get; set; }
    }
}
