using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ProEShop.DataLayer.Context;

namespace ProEShop.IocConfig;
public static class RegisterServices
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer("Server=.;Database=ProEShop;trusted_connection=true;MultipleActiveResultSets=true;");

        });
        return services;
    }
}
