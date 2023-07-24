using DotNet_MVC_.Models;
using Microsoft.EntityFrameworkCore;


namespace DotNet_MVC_.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }



}
