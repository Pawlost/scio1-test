using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scio1.Common.Installer;

namespace Scio1.DAL.Installer;

public class DALInstaller : IInstaller
{
    private const string ConnectionStringName = "Scio1WebAppContext";
    private const int Timeout = 12;
    public void Install(IServiceCollection serviceCollection, IConfiguration? configuration)
    {
        var connectionString = configuration?.GetConnectionString(ConnectionStringName);

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException($"Connection string not found.");
        }

        serviceCollection.AddDbContext<Scio1DbContext>(options => options.UseSqlServer(connectionString, options => options.CommandTimeout(Timeout)));
    }
}
