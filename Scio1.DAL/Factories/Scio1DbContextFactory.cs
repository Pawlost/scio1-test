using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Scio1.DAL.Factories
{
    public class Scio1DbContextFactory : IDesignTimeDbContextFactory<Scio1DbContext>
    {
        public Scio1DbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Scio1DbContextFactory>(optional: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<Scio1DbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Scio1WebAppContext"));
            return new Scio1DbContext(optionsBuilder.Options);
        }
    }
}
