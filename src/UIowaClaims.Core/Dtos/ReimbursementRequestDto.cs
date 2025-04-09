using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UIowaClaims.Core.Dtos
{
    public class ReimbursementRequestDto
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public FileDto File { get; set; }

    }
}
