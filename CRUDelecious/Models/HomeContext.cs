using Microsoft.EntityFrameworkCore;

namespace CRUDelecious.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext (DbContextOptions options) : base(options){}
        public DbSet<Dish> Dishes {get;set;}
        
    }
}