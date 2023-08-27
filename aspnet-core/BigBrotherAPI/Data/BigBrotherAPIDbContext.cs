using BigBrotherAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace BigBrotherAPI.Data;

public class BigBrotherAPIDbContext : AbpDbContext<BigBrotherAPIDbContext>
{
    public BigBrotherAPIDbContext(DbContextOptions<BigBrotherAPIDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        builder.Entity<Motherfucker>(b =>
        {
            b.ConfigureFullAuditedAggregateRoot();
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<Poll>(b =>
        {
            b.ConfigureAuditedAggregateRoot();
        });

        builder.Entity<PollResult>(b =>
        {
            b.ConfigureFullAuditedAggregateRoot();
            b.HasMany(cu => cu.Motherfuckers)
                .WithOne()
                .HasForeignKey("PollResultId");
        });

        builder.Entity<PollResultMotherfucker>(b =>
        {
            b.HasKey("MotherfuckerId");
            b.ConfigureFullAuditedAggregateRoot();
        });

        builder.Entity<Vote>(b =>
        {
            b.ConfigureFullAuditedAggregateRoot();
        });
        /* Configure your own entities here */

    }
}
