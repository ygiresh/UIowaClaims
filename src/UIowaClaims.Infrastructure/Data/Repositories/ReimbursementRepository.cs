using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIowaClaims.Application.Interfaces;
using UIowaClaims.Core.Dtos;
using UIowaClaims.Core.Models;
using UIowaClaims.Infrastructure.Persistence;

namespace UIowaClaims.Infrastructure.Repositories
{
    public class ReimbursementRepository : IReimbursementRepository
    {
        private readonly AppDbContext _context;

        public ReimbursementRepository(AppDbContext context) => _context = context;

        public async Task<int> AddFormAsync(ReimbursementForm form)
        {
            _context.ReimbursementForms.Add(form);
            await _context.SaveChangesAsync();
            return form.Id;
        }

        public async Task<int> AddFileAsync(UploadedFile file)
        {
            _context.UploadedFiles.Add(file);
            await _context.SaveChangesAsync();
            return file.Id;
        }

        public async Task<int> LinkFormToFileAsync(int formId, int fileId)
        {
            var link = new ReimbursementWithFile { ReimbursementFormId = formId, UploadedFileId = fileId };
            _context.ReimbursementWithFiles.Add(link);
            await _context.SaveChangesAsync();
            return link.Id;
        }


        /*public async Task<List<ReimbursementRequestDto>> GetAllWithFilesAsync()
        {
            return await _context.ReimbursementWithFiles
                .Include(link => link.UploadedFileId)
                .Include(link => link.ReimbursementFormId)
                .Select(link => new ReimbursementRequestDto
                {
                    Id = link.ReimbursementFormId,
                    UserId = _context.ReimbursementForms.Include(rf => rf.Id == link.ReimbursementFormId).Select(x => x.UserId).FirstOrDefault(),
                    Amount = _context.ReimbursementForms.Include(rf => rf.Id == link.ReimbursementFormId).Select(x => x.Amount).FirstOrDefault(),
                    Date = _context.ReimbursementForms.Include(rf => rf.Id == link.ReimbursementFormId).Select(x => x.Date).FirstOrDefault(),
                    File = new FileDto
                    {
                        Id = link.UploadedFileId,
                        FileName = _context.UploadedFiles.Include(rf => rf.Id == link.UploadedFileId).Select(x => x.FileName).FirstOrDefault(),
                        FilePath = _context.UploadedFiles.Include(rf => rf.Id == link.UploadedFileId).Select(x => x.FilePath).FirstOrDefault(),
                        Size = _context.UploadedFiles.Include(rf => rf.Id == link.UploadedFileId).Select(x => x.Size).FirstOrDefault(),
                    }
                })
                .ToListAsync();
        }*/


        public async Task<List<ReimbursementRequestDto>> GetAllWithFilesAsync()
        {
            return await _context.ReimbursementWithFiles
                .Include(link => link.UploadedFile)
                .Include(link => link.ReimbursementForm)
                .Select(link => new ReimbursementRequestDto
                {
                    Id = link.ReimbursementFormId,
                    UserId = link.ReimbursementForm.UserId,
                    Amount = link.ReimbursementForm.Amount,
                    Date = link.ReimbursementForm.Date,
                    File = new FileDto
                    {
                        Id = link.UploadedFileId,
                        FileName = link.UploadedFile.FileName,
                        FilePath = link.UploadedFile.FilePath,
                        Size = link.UploadedFile.Size
                    }

                })
                .ToListAsync();
        }


    }
}
