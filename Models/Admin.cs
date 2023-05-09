using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Fbs_webApi_v1.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }

        [Required]
        [PasswordPropertyText]
        public string password { get; set;}

    }
}
