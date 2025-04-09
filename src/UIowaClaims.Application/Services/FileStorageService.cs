using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using UIowaClaims.Application.Interfaces;
using UIowaClaims.Core.Dtos;

namespace UIowaClaims.Application.Services
{
        public class FileStorageService : IFileStorageService
        {
            private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources\\UploadedFiles");

            public FileStorageService()
            {
                if (!Directory.Exists(_basePath))
                    Directory.CreateDirectory(_basePath);
            }

            public async Task<(string filePath, string fileName, long size)> SaveFileAsync(FileDto file)
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var fullPath = Path.Combine(_basePath, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.Content.CopyToAsync(stream);
                }

                return (fullPath, file.FileName, file.Size);
            }
        }
    

}
