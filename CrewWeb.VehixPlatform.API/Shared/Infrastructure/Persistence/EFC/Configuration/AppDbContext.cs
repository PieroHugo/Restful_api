using CrewWeb.VehixPlatform.API.GenericMonitoring.Infrastructure.Persistence.EFC.Configuration.Extensions;
using CrewWeb.VehixPlatform.API.GenericAuth.Infrastructure.Persistence.EFC.Configuration.Extensions;
using CrewWeb.VehixPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CrewWeb.VehixPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        // Add the created and updated interceptor
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Apply configurations for the Generic Monitoring bounded context
        builder.ApplyGenericMonitoringConfiguration();
        
        // Apply configurations for the Generic Authentication bounded context
        builder.ApplyGenericAuthConfiguration();

        // Use snake case naming convention for the database
        builder.UseSnakeCaseNamingConvention();
    }
}