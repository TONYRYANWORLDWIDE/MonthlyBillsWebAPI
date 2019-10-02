using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MonthlyBillsWebAPI.Models2
{
    public class Metadata
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Bill")]
        public string Bill { get; set; }

        [Required]
        [Range(0, 31)]
        [Display(Name = "Date")]
        public Nullable<float> Date { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public Nullable<float> Cost { get; set; }

        public string BillAlias { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
