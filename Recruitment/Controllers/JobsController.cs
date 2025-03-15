using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecruitmentPlatform.Application.Features.Jobs.Commands;

namespace Recruitment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JobsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddJob([FromBody] CreateJobCommand command)
        {
            var jobId = await _mediator.Send(command);
            return Ok(new { JobId = jobId, Message = "Job added successfully!" });
        }
    }
}
