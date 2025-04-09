using System;
using System.Collections.Generic;
using System.Text;

namespace UIowaClaims.Core.Models
{
    public class ReimbursementForm
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
