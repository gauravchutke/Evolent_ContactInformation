using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactInformationModels
{
    public class ContactInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int intContactInformationId { get; set; }

        [Required(ErrorMessage = "Please Enter First Name.")]
        public string strFirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name.")]
        public string strLastName { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address.")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email Address")]
        public string strEmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number.")]
        [MinLength(10, ErrorMessage = "Phone Number Must Contains Only 10 Digits.")]
        [MaxLength(10, ErrorMessage = "Phone Number Must Contains Only 10 Digits.")]
        [Phone(ErrorMessage = "Please Enter Valid Phone Number.")]
        public string strPhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Status.")]
        [MinLength(6, ErrorMessage = "Please Enter Valid Status.")]
        [MaxLength(8, ErrorMessage = "Please Enter Valid Status.")]
        public string strStatus { get; set; }
    }
}
