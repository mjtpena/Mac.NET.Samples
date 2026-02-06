using HelloWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWebAPI
{
    public class DockerDbContext : DbContext
    {
        public DockerDbContext(DbContextOptions<DockerDbContext> options)
            : base(options)
        {
        }

        public DbSet<MyItem> MyItems { get; set; }
    }
}