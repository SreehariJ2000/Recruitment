using MediatR;
using RecruitmentPlatform.Domain.Models;

namespace RecruitmentPlatform.Application.Features.Jobs.Commands
{
    public class CreateJobCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
    }
}
