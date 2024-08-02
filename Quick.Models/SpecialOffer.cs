using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Models
{

    public class SpecialOffer
    {
        public int SpecialOfferId { get; set; }  // Primary key for the special offer

        [Required]  // Name is required
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters.")]
        public string Description { get; set; }  // Optional description

        [Required]  // Start date is required
        public DateTime StartDate { get; set; }

        [Required]  // End date is required
        public DateTime EndDate { get; set; }
    }
}
