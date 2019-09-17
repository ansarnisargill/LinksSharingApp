using Microsoft.EntityFrameworkCore;
using LinkShareApp.Models;

namespace LinkShareApp.Models
{
    public class LinkAppContext : DbContext
    {
        public LinkAppContext(DbContextOptions<LinkAppContext> options)
            : base(options)
        {

        }
        public DbSet<Link> Links { get; set; }
    }

}