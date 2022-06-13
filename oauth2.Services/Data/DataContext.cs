using Microsoft.EntityFrameworkCore;
using oauth2.Model.Entity;

namespace oauth2.Services.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }


    }
}
