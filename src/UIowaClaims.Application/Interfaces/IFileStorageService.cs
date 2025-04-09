using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using UIowaClaims.Core.Dtos;

namespace UIowaClaims.Application.Interfaces
{
    public interface IFileStorageService
    {
        Task<(string filePath, string fileName, long size)> SaveFileAsync(FileDto file);
    }
}
