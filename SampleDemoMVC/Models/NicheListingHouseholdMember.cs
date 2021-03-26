using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class NicheListingHouseholdMember
    {
        public int Id { get; set; }
        public int ListingHouseholdId { get; set; }
        public NicheListingHousehold ListingHousehold { get; set; }

        [DisplayName("Member Type")]
        public int MemberTypeId { get; set; }



        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Date Of Birth")]
        public DateTime? DOB { get; set; }

        [DisplayName("Supporting Document Type")]
        public int? SupportingDocumentTypeId { get; set; }


        [DisplayName("Supporting Document")]
        public string SupportingDocument { get; set; }

        /*Mother Specific Details*/

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? EDD { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
    }
}