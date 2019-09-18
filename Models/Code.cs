using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShareApp.Models
{
    public class Code
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int LinkId { get; set; }
        public Link Link { get; set; }
        [Required]
        [Display(Name = "Code")]
        public string CodeTerm { get; set; }
        [Required]
        [Display(Name = "Valid Till")]
        public DateTime ValidTill { get; set; }
        public decimal Amount { get; set; }


    }
}
