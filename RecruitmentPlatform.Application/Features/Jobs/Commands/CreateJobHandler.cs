using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RecruitmentPlatform.Domain.Models;
using RecruitmentPlatform.Domain.Repositories;

namespace RecruitmentPlatform.Application.Features.Jobs.Commands
{
    public class CreateJobHandler : IRequestHandler<CreateJobCommand, int>
    {
        private readonly IJobRepository _jobRepository;

        public CreateJobHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<int> Handle(CreateJobCommand request, CancellationToken cancellationToken)
        {
            var job = new Job
            {
                Title = request.Title,
                Description = request.Description,
                Company = request.Company
            };

            await _jobRepository.AddJobAsync(job);
            return job.Id;
        }
    }
}
