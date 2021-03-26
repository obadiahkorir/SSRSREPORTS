using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class NicheListingHousehold 
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }

        [DisplayName("Has pregnant woman?")]
        public int HasPregnantWomanId { get; set; }


        [DisplayName("Has children under 15 months?")]
        public int HasEligibleChildrenId { get; set; }


        [DisplayName("No. of Pregnant women")]
        public int PregnantWomenNumber { get; set; } = 0;
        [DisplayName("No. of children under 15 months")]
        public int EligibleChildrenNumber { get; set; } = 0;


        [Display(Name = "Status")]
        public int StatusId { get; set; }


        [Display(Name = " Enumerator")]
        public int? EnumeratorId { get; set; }


        [Display(Name = " Enumerator")]
        public int? RegistrationEnumeratorId { get; set; }

        [DisplayName("Date Submitted")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? SubmittedOn { get; set; }

        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        [Display(Name = "Geo Position  ")]
        public string GeoPosition => $"[ {Longitude}, {Latitude}]";

        [DisplayName("Reason for Rejecting")]
        public int? RejectionReasonId { get; set; }


        [DisplayName("Specify the reason")]
        public string OtherRejectionReason { get; set; }

        [DisplayName("Approval Notes")]
        [StringLength(1000)]
        
        public string ApprovalNotes { get; set; }
    }
}