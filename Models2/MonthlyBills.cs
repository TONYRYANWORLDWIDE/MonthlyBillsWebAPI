
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace MonthlyBillsWebAPI.Models2
{
    public partial class MonthlyBills
    {
        public int Id { get; set; }
        public string Bill { get; set; }
        public float? Cost { get; set; }
        public int Date { get; set; }
        public string BillAlias { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
      
        [JsonIgnore]
        public virtual AspNetUsers User { get; set; }
    }
}
