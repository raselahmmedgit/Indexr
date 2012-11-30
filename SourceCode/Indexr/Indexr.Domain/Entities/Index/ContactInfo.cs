using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Indexr.Domain
{
    public class ContactInfo
    {
        [Key]
        public int ContactInfoId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [NotMapped]
        [DisplayName("Full Name")]
        public string FullName { get { return this.FirstName + " " + this.LastName; } }

        [DisplayName("Sex")]
        [Required(ErrorMessage = "Sex is required.")]
        public int Sex { get; set; }

        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "Date Of Birth is required.")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Present Address")]
        [Required(ErrorMessage = "Present Address is required.")]
        [MaxLength(200)]
        public string PresentAddress { get; set; }

        [Display(Name = "Permanent Address")]
        [Required(ErrorMessage = "Permanent Address is required.")]
        [MaxLength(200)]
        public string PermanentAddress { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [MaxLength(50)]
        public string MobileNumber { get; set; }

        [Display(Name = "Alternative Mobile Number")]
        [MaxLength(50)]
        public string AlternativeMobileNumber { get; set; }

        [Display(Name = "National ID Number")]
        [Required(ErrorMessage = "National ID Number is required.")]
        [MaxLength(50)]
        public string NationalIdNumber { get; set; }

        [Display(Name = "Passport Number")]
        [Required(ErrorMessage = "Passport Number is required.")]
        [MaxLength(50)]
        public string PassportNumber { get; set; }

        [Display(Name = "Profile Thumb Image")]
        public string ThumbImageUrl { get; set; }

        [Display(Name = "Profile Small Image")]
        public string SmallImageUrl { get; set; }
    }
}
