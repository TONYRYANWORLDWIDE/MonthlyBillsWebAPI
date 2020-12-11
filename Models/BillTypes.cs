using System;
using System.Collections.Generic;

namespace MonthlyBillsWebAPI.Models
{
    public partial class BillTypes
    {
        public BillTypes()
        {
            OneOffBills = new HashSet<OneOffBills>();
        }

        public int Id { get; set; }
        public string BillType { get; set; }

        public virtual ICollection<OneOffBills> OneOffBills { get; set; }
    }
}
