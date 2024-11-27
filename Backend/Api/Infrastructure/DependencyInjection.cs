using Infrastructure.Services.Car;
using Infrastructure.Services.Part;
using Infrastructure.Services.PartReplacement;
using Infrastructure.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<IPartService, PartService>();
        services.AddScoped<IPartReplacementService, PartReplacementService>();
    }
}