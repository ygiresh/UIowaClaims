using System.ComponentModel.DataAnnotations;

namespace UIowaClaims.API.ViewModels
{
    public class ReimbursementFormModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public IFormFile File { get; set; }
    }

}
