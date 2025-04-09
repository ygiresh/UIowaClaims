using System;
using System.Collections.Generic;
using System.Text;

namespace UIowaClaims.Core.Models
{
    public class ReimbursementWithFile
    {
        public int Id { get; set; }

        public int ReimbursementFormId { get; set; }
        public ReimbursementForm ReimbursementForm { get; set; }

        public int UploadedFileId { get; set; }
        public UploadedFile UploadedFile { get; set; }
    }
}
