using System;
using System.Collections.Generic;
using System.Text;

namespace UIowaClaims.Core.Models
{
    public class UploadedFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long Size { get; set; }
    }
}
