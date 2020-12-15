using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class TransactionsCMP
    {
        public string Account_Id { get; set; }
        public string Account_Owner { get; set; }
        public double? Amount { get; set; }
        public string Authorized_Date { get; set; }
        public string Category { get; set; }
        public string Category_Id { get; set; }
        public DateTime Date { get; set; }
        public string Iso_Currency_Code { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Payment_Channel { get; set; }
        public string Payment_Meta { get; set; }
        //public string Pending { get; set; }
        public bool Pending { get; set; }
        public string Pending_Transaction_Id { get; set; }
        public string Transaction_Id { get; set; }
        public string Transaction_Type { get; set; }
        public string Unofficial_Currency_Code { get; set; }
        public string Transaction_Code { get; set; }
        public string Merchant_Name { get; set; }
    }
}
