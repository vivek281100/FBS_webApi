using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Fbs_webApi_v1.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        [Required(ErrorMessage = "User Name Is Required")]
        [StringLength(20,ErrorMessage ="length should be less than 20")]
        public string? Name { get; set;}

        [Required(ErrorMessage = "User Email Is Required")]
        [EmailAddress]
        public string? Email { get; set;}

        [Required]
        [PasswordPropertyText]
        public string? password { get; set;}

        [Required]
        [Phone]
        public string? PhoneNumber { get; set;}
    }
}
