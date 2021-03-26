using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class SubLocation
    {
        [StringLength(20)]
        [Required]
        [Display(Name = "Sub Location Code")]
        public string Code { get; set; }


        [Display(Name = "Sub County")]
        public int ConstituencyId { get; set; }

        [Display(Name = "Sub Location")]
        public int Id { get; set; }

        [Display(Name = "Locality")]
        public int LocalityId { get; set; }


        [Display(Name = "Location")]
        public int LocationId { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Sub Location Name")]
        public string Name { get; set; }
    }




}