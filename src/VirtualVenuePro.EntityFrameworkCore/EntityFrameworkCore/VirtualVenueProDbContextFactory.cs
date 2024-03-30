using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace VirtualVenuePro.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class VirtualVenueProDbContextFactory : IDesignTimeDbContextFactory<VirtualVenueProDbContext>
{
    public VirtualVenueProDbContext CreateDbContext(string[] args)
    {
        VirtualVenueProEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<VirtualVenueProDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new VirtualVenueProDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../VirtualVenuePro.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
