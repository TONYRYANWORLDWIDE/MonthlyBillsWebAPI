using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class Transactions1
    {
        public string AccountId { get; set; }
        public string AccountOwner { get; set; }
        public double? Amount { get; set; }
        public string AuthorizedDate { get; set; }
        public string Category { get; set; }
        public string CategoryId { get; set; }
        public DateTime Date { get; set; }
        public string IsoCurrencyCode { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string PaymentChannel { get; set; }
        public string PaymentMeta { get; set; }
        public string Pending { get; set; }
        public string PendingTransactionId { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string UnofficialCurrencyCode { get; set; }
        public string TransactionCode { get; set; }
        public string MerchantName { get; set; }
    }
}
