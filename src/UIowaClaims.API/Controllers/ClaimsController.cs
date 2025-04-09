using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UIowaClaims.API.ViewModels;
using UIowaClaims.Application.Interfaces;
using UIowaClaims.Core.Dtos;
using UIowaClaims.Core.Models;

namespace UIowaClaims.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IReimbursementService reimbursmentService;
        public ClaimsController(IReimbursementService reimbursmentService) 
            => this.reimbursmentService = reimbursmentService;

        [HttpPost("submit")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Submit([FromForm] ReimbursementFormModel form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var dto = new ReimbursementRequestDto
            {
                UserId = form.UserId,
                Amount = form.Amount,
                Date = form.Date,
                File = new FileDto
                {
                    FileName = form.File.FileName,
                    ContentType = form.File.ContentType,
                    Size = form.File.Length,
                    Content = form.File.OpenReadStream()
                }
            };

            var (formId, fileId, linkId) = await reimbursmentService.SubmitAsync(dto);
            return Ok(new { formId, fileId, linkId });
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var forms = await reimbursmentService.GetAlAsync();
            return Ok(forms);
        }
    }
}
