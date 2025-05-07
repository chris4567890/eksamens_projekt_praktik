using eksamn_project.Server.Models;
using eksamn_project.Server.Data;
using eksamn_project.Server.Models;
using Microsoft.EntityFrameworkCore;
namespace eksamn_project.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<Overenskomst> overenskomsts { get; set; }
    }
}
