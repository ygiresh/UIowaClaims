using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIowaClaims.Core.Common;
using UIowaClaims.Core.Dtos;

namespace UIowaClaims.Application.Interfaces
{
    public interface IReimbursementService
    {
        Task<(int formId, int fileId, int linkId)> SubmitAsync(ReimbursementRequestDto request);
        Task<List<ReimbursementRequestDto>> GetAlAsync();
    }
}
