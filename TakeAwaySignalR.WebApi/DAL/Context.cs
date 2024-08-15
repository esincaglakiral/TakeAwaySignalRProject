using Microsoft.EntityFrameworkCore;

namespace TakeAwaySignalR.WebApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CAGLA\\SQLEXPRESS;initial Catalog=TakeAwayNightDeliveryDb;integrated Security=true");
        }

        public DbSet<Delivery> Deliveries { get; set; }
    }
}
