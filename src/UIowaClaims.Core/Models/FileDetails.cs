using System;
using System.Collections.Generic;
using System.Text;

namespace UIowaClaims.Core.Models
{
    public class FileDetails
    {
        public int  FileId { get; set; } 
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Size { get; set; }
        public string FileLocationPath { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
        public string UploadedBy { get; set; }
    }
}
