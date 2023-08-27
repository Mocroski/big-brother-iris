using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace BigBrotherAPI.Data;

public class BigBrotherAPIEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public BigBrotherAPIEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BigBrotherAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BigBrotherAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
