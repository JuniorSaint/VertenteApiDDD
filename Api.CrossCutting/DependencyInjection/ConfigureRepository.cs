using Api.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repositories;
using Api.Data.Implementations;
using Api.Domain.Interfaces.Repository;
using Api.Data.Implementation;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {

        private static string Host = "localhost";
        private static string User = "Junior";
        private static string DBname = "Vertente";
        private static string Password = "123456";
        private static string Port = "5432";

        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<IClientRepository, ClientImplementations>();
            serviceCollection.AddScoped<IAddressRepository, AddressImplementation>();
            serviceCollection.AddScoped<IStateRepository, StateImplementation>();
            serviceCollection.AddScoped<IProductRepository, ProductImplementation>();
            serviceCollection.AddScoped<IPhoneRepository, PhoneImplementations>();
            serviceCollection.AddScoped<IImagePathRepository, ImagePathImplementation>();
            serviceCollection.AddScoped<IProductTypeRepository, ProductTypeImplementation>();

            serviceCollection.AddDbContext<MyContext>(
                 options => options.UseNpgsql($"Server={Host}; Port={Port}; Database={DBname}; Uid={User}; Pwd={Password}")
                 );
        }
    }
}
