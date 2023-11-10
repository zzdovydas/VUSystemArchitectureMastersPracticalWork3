using CSMasterSystemArchitecture1.Models;
using Microsoft.EntityFrameworkCore;

namespace CSMasterSystemArchitecture1.Context
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Item> Items { get; set; }

    }
}
