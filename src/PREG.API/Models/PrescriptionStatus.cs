using System;
using System.ComponentModel.DataAnnotations;

namespace PREG.API.Models
{
    public class PrescriptionStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime? Updated { get; set; }

        public string UpdatedBy { get; set; }
    }

}