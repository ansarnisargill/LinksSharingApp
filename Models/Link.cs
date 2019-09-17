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
        [Required(AllowEmptyStrings =false,ErrorMessage ="Url is necessary")]
        public string Url { get; set; }

    }
}
