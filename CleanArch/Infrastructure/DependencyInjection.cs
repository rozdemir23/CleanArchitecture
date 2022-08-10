using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {


            services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDBContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("TekstilDatabase")));

          /*  //Redis Kurulumu
             var connectionString = configuration.GetConnectionString("Redis");

             var redisConnection = ConnectionMultiplexer.Connect(connectionString);
             services.AddSingleton<IConnectionMultiplexer>(redisConnection);

             var redisDb = redisConnection.GetDatabase(0);
             services.AddSingleton(redisDb); */

            return services;
        }
    }
}