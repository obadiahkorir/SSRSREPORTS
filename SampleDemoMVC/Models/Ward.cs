using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class Ward
    {
        [StringLength(20)]
        [Required]
        [Display(Name = "Ward Code")]
        public string Code { get; set; }
        [Required]
        [Display(Name = "Constituency")]
        public int ConstituencyId { get; set; }

        [Display(Name = "Ward ID")]
        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Ward Name")]
        public string Name { get; set; }

    }
}