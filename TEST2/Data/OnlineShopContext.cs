using Microsoft.EntityFrameworkCore;
using TEST2.Models;

namespace TEST2.Data
{
    public class OnlineShopContext:DbContext //Inheritance
    {
        public OnlineShopContext()
        {

        }

        public OnlineShopContext(DbContextOptions<OnlineShopContext>options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("BeviConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        //DBSets
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
