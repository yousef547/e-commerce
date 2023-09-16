using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastracure.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Products> products { get; set; }
    }
}
