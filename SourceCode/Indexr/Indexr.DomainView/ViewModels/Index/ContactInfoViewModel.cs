/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Designed and Implemented By:
Rasel Ahmmed
Software Engineer, I Like .NET
Twitter: http://twitter.com/raselbappi | Blog: http://springsolution.net | About Me: http://springsolution.net/about-me/
   
*******************************************************/

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Indexr.DomainView
{
    public class ContactInfoViewModel : BaseViewModel
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

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(200, ErrorMessage = "Maximum characters must be 200.")]
        [MaxLength(200)]
        public string Email { get; set; }

        [Display(Name = "Present Address")]
        [Required(ErrorMessage = "Present Address is required.")]
        [StringLength(200, ErrorMessage = "Maximum characters must be 200.")]
        [MaxLength(200)]
        public string PresentAddress { get; set; }

        [Display(Name = "Permanent Address")]
        [Required(ErrorMessage = "Permanent Address is required.")]
        [StringLength(200, ErrorMessage = "Maximum characters must be 200.")]
        [MaxLength(200)]
        public string PermanentAddress { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Maximum characters must be 50.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(50, ErrorMessage = "Maximum characters must be 50.")]
        [MaxLength(50)]
        public string MobileNumber { get; set; }

        [Display(Name = "Alternative Mobile Number")]
        [StringLength(50, ErrorMessage = "Maximum characters must be 50.")]
        [MaxLength(50)]
        public string AlternativeMobileNumber { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(100)]
        [StringLength(100, ErrorMessage = "Maximum characters must be 100.")]
        public string FacebookProfile { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(100)]
        [StringLength(100, ErrorMessage = "Maximum characters must be 100.")]
        public string LinkedInProfile { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(100)]
        [StringLength(100, ErrorMessage = "Maximum characters must be 100.")]
        public string GooglePlusProfile { get; set; }

        [Display(Name = "National ID Number")]
        [Required(ErrorMessage = "National ID Number is required.")]
        [StringLength(50, ErrorMessage = "Maximum characters must be 50.")]
        [MaxLength(50)]
        public string NationalIdNumber { get; set; }

        [Display(Name = "Passport Number")]
        [Required(ErrorMessage = "Passport Number is required.")]
        [StringLength(50, ErrorMessage = "Maximum characters must be 50.")]
        [MaxLength(50)]
        public string PassportNumber { get; set; }

        [Display(Name = "Profile Thumb Image")]
        [StringLength(100, ErrorMessage = "Maximum characters must be 100.")]
        public string ThumbImageUrl { get; set; }

        [Display(Name = "Profile Small Image")]
        [StringLength(100, ErrorMessage = "Maximum characters must be 100.")]
        public string SmallImageUrl { get; set; }
    }
}
