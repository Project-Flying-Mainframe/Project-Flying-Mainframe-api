using Project.Flying.Mainframe.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Flying.Mainframe.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }
    }
}