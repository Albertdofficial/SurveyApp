using Microsoft.EntityFrameworkCore;
using SurveyApp.Model;

namespace SurveyApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<ResponseDbTable> responseDbTable { set; get; }
        public object ResponseDbTable { get; internal set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

    }
}
