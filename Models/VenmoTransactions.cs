using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class VenmoTransactions
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? PaymentId { get; set; }
        public long? TransactionId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string Userid1 { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
    }
}
