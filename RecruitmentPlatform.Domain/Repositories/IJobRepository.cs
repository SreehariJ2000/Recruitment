using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentPlatform.Domain.Models;

namespace RecruitmentPlatform.Domain.Repositories
{

    public interface IJobRepository
    {
        Task AddJobAsync(Job job);
    }
}
