using hearing_test.Models.CustomModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace hearing_test.Models
{
    public class ApplicationDBContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base (options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestion { get; set; }
        public DbSet<History> History { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ExamQuestion>().HasKey(e => new { e.ExamId, e.QuestionId });
            builder.Entity<History>().HasKey(e => new { e.UserId, e.ExamId, e.QuestionId, e.Created_at });
            base.OnModelCreating(builder);
        }
    }
}
