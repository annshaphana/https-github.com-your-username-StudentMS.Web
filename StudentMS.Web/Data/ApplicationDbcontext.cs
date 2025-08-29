using Microsoft.EntityFrameworkCore;
using StudentMS.Web.Models;

namespace StudentMS.Web.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
