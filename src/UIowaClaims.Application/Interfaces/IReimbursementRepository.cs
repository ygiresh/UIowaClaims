using System.Collections.Generic;
using System.Threading.Tasks;
using UIowaClaims.Core;
using UIowaClaims.Core.Dtos;
using UIowaClaims.Core.Models;

namespace UIowaClaims.Application.Interfaces
{
    public interface IReimbursementRepository
    {
        Task<int> AddFormAsync(ReimbursementForm form);
        Task<int> AddFileAsync(UploadedFile file);
        Task<int> LinkFormToFileAsync(int formId, int fileId);
        Task<List<ReimbursementRequestDto>> GetAllWithFilesAsync();
    }
}
