using Microsoft.EntityFrameworkCore;
using SB_App.Models;

namespace SB_App.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Question> Questions { get; set; }

    }
}
