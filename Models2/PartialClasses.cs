using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace MonthlyBillsWebAPI.Models2
{
    public class PartialClasses
    {

        [MetadataType(typeof(Metadata))]
        public partial class MonthlyBill
        {
        }
    }
}
