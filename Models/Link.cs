using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShareApp.Models
{
    public class Link
    {
        [Key]
        public int ID { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Url Name is necessary")]
        [Display(Name ="Web Url Name")]
        public string UrlName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is necessary")]
        [Display(Name = "Url Description")]
        public string Description { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Actual Url is necessary")]
        [Display(Name = "Actual Url")]
        public string Url { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Url is necessary")]
        [Display(Name = "Per Day Price")]
        public decimal PricePerDay { get; set; }


    }
}
