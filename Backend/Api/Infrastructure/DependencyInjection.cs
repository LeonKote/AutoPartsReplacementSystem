using Infrastructure.Services.Car;
using Infrastructure.Services.CarRepository;
using Infrastructure.Services.Part;
using Infrastructure.Services.PartReplacement;
using Infrastructure.Services.PartReplacementRepository;
using Infrastructure.Services.PartRepository;
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

        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IPartRepository, PartRepository>();
        services.AddScoped<IPartReplacementRepository, PartReplacementRepository>();
    }
}