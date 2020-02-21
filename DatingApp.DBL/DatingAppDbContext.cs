using DatingApp.DBL.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.DBL
{
    public class DatingAppDbContext : DbContext
    {
        public DatingAppDbContext(DbContextOptions<DatingAppDbContext> options) : base(options){}

        public DbSet<Value> Values { get; set;  }
    }
}
