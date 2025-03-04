using Microsoft.EntityFrameworkCore;
using BlazorCrudCDx.Model;


namespace BlazorCrudCDx.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> Options) : base(Options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
