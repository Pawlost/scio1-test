using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Scio1.Common.Installer;

public interface IInstaller
{
    void Install(IServiceCollection serviceCollection, IConfiguration? configuration);
}