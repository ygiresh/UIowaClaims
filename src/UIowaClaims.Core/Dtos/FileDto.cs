using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UIowaClaims.Core.Dtos
{

    public class FileDto
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Stream Content { get; set; }
        public long Size { get; set; }
        public string FilePath { get; set; }
    }

}
