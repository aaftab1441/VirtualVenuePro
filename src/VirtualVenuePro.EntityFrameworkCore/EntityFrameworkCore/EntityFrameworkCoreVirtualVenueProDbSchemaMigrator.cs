using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VirtualVenuePro.Data;
using Volo.Abp.DependencyInjection;

namespace VirtualVenuePro.EntityFrameworkCore;

public class EntityFrameworkCoreVirtualVenueProDbSchemaMigrator
    : IVirtualVenueProDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreVirtualVenueProDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the VirtualVenueProDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<VirtualVenueProDbContext>()
            .Database
            .MigrateAsync();
    }
}
