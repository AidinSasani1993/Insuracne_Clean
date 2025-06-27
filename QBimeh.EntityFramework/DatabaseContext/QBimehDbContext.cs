using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QBimeh.Domain.Entities.Users;

namespace QBimeh.EntityFramework.DatabaseContext
{
    public class QBimehDbContext : IdentityDbContext
    {
        public QBimehDbContext(DbContextOptions options) : base(options)
        {
        }

        protected QBimehDbContext()
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
