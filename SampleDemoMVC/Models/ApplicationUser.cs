using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        // [RegularExpression("^[-_.A-Za-z]*$", ErrorMessage = "Invalid!")]
        [Display(Name = "Surname"), Required, StringLength(50)]
        public string Surname { get; set; }

        //   [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets")]
        [Display(Name = "First Name"), Required, StringLength(50)]

        public string FirstName { get; set; }

        // [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets")]
        [Display(Name = "Middle Name"), StringLength(50)]
        public string MiddleName { get; set; }

        [Display(Name = "Last Activity Date")]
        public DateTime? ActivityDate { get; set; }

        [Display(Name = "Avatar"), StringLength(70)]
        public string Avatar { get; set; }

        [Display(Name = "Created By")]
        public string CreatedById { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Deactivate Date")]
        public DateTime? DeactivateDate { get; set; }

        [RegularExpression("^[-_.A-Za-z0-9 ,]*$", ErrorMessage = "Invalid!")]
        [Display(Name = "Department"), StringLength(100)]
        public string Department { get; set; }

        [Display(Name = "Avatar")]
        public string DisplayAvatar => string.IsNullOrEmpty(Avatar) ? "avatar.png" : Avatar;

        [Display(Name = "Display Names")]
        public string DisplayName => $"{FirstName} {Surname}";

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address"), Required, StringLength(100), MaxLength(100)]
        public override string Email { get; set; }

        [Display(Name = "Is Email Address Confirmed")]
        public override bool EmailConfirmed { get; set; }



        [Display(Name = "Full names")]
        public string FullName => $"{FirstName} {MiddleName} {Surname}";



        [Display(Name = "Activity Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Locked Status")]
        public bool IsLocked { get; set; }

        [Display(Name = "Last Login Date")]
        public DateTime? LoginDate { get; set; }



        [Display(Name = "Modified By")]
        public string ModifiedById { get; set; }

        [Display(Name = "Modified On")]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name = "Name")]
        public string Name => $"{FirstName}  {MiddleName}";

        // [RegularExpression("^[-_.A-Za-z0-9]*$", ErrorMessage = "Invalid!")]
        [Display(Name = "Organization"), StringLength(100)]
        public string Organization { get; set; }

        [Display(Name = "Last Password Changed Date")]
        public DateTime? PasswordChangedOn { get; set; }

        // [Display(Name = "Access Failed Count")]
        // public override int AccessFailedCount { get; set; }
        [StringLength(256)]
        public override string PasswordHash { get; set; }

        [Display(Name = "Phone Number"), Required, StringLength(20)]
        public override string PhoneNumber { get; set; }

        [Display(Name = "Is Phone Number Confirmed")]
        public override bool PhoneNumberConfirmed { get; set; }

        //[RegularExpression("^[-_.A-Za-z0-9]*$", ErrorMessage = "Invalid!")]
        [Display(Name = "Position"), Required, StringLength(100)]
        public string Position { get; set; }

        [StringLength(256)]
        public override string SecurityStamp { get; set; }



        [DataType(DataType.EmailAddress)]
        [Display(Name = "Username"), Required, StringLength(100), MaxLength(100)]
        public override string UserName { get; set; }

        // [RegularExpression("^[-_.A-Za-z0-9]*$", ErrorMessage = "Invalid!")]
        [Display(Name = "Staff Number"), StringLength(100)]
        public string StaffNo { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid!")]
        [Display(Name = "National ID No."), StringLength(10)]
        public string NationalIdNo { get; set; }
        public string RoleId { get; set; }
        public ApplicationRole Role { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description,
            DateTime createdDate, bool isExternal, string createdById)
            : base(roleName)
        {
            base.Name = roleName;
            this.Description = description;
            this.CreatedOn = createdDate;
            this.IsExternal = isExternal;
            this.CreatedById = createdById;
        }

        public string Description { get; set; }
        [DisplayName("Can Self-register?")]
        public bool IsExternal { get; set; }
        [DisplayName("Active?")]
        public bool IsActive { get; set; }

        [DisplayName("Date Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Created By")]
        public string CreatedById { get; set; }

        [DisplayName("Date Modified")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? ModifiedOn { get; set; }

        [DisplayName("Modified By")]
        public string ModifiedById { get; set; }

        public int MisId { get; set; }

        [DisplayName("Access Level")]
        public int? AccessLevelId { get; set; }
    }
}
