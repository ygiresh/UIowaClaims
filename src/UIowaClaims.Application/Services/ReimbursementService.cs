using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIowaClaims.Application.Interfaces;
using UIowaClaims.Core.Common;
using UIowaClaims.Core.Dtos;
using UIowaClaims.Core.Models;

namespace UIowaClaims.Application.Services
{
    public class ReimbursementService : IReimbursementService
    {
        private readonly IReimbursementRepository _repo;
        private readonly IFileStorageService _fileStorage;

        public ReimbursementService(IReimbursementRepository repo, IFileStorageService fileStorage)
        {
            _repo = repo;
            _fileStorage = fileStorage;
        }

        public async Task<(int formId, int fileId, int linkId)> SubmitAsync(ReimbursementRequestDto request)
        {
            var (filePath, fileName, size) = await _fileStorage.SaveFileAsync(request.File);
            var fileId = await _repo.AddFileAsync(new UploadedFile { FileName = fileName, FilePath = filePath, Size = size });
            var formId = await _repo.AddFormAsync(new ReimbursementForm { UserId = request.UserId, Amount = request.Amount, Date = request.Date });
            var linkId = await _repo.LinkFormToFileAsync(formId, fileId);
            return (formId, fileId, linkId);
        }

        public async Task<List<ReimbursementRequestDto>> GetAlAsync()
        {
            return await _repo.GetAllWithFilesAsync();
        }

    }
}
