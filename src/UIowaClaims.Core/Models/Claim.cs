using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UIowaClaims.Core.Models
{
    public class ReimbursementClaim
    {
        public int Id { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public double Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReferenceDate { get; set; }
        public DateTime SubmittedOn { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string SubmittedBy { get; set; }
        
    }
}
