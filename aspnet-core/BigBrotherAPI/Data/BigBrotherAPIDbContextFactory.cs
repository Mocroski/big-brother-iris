using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BigBrotherAPI.Data;

public class BigBrotherAPIDbContextFactory : IDesignTimeDbContextFactory<BigBrotherAPIDbContext>
{
    public BigBrotherAPIDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BigBrotherAPIDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new BigBrotherAPIDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
