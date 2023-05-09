using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fbs_webApi_v1.Models
{
    public class SeatAllocation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Flight_Id")]
        public long Flight_Id { get; set; }
    }
}
