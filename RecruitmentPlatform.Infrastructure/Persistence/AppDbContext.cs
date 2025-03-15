using Microsoft.EntityFrameworkCore;
using RecruitmentPlatform.Domain.Models;

namespace RecruitmentPlatform.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
    }
}
