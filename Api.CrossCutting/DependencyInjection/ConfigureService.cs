using Api.Domain.Interfaces.Services;
using Api.Service.Service;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IClientService, ClientService>();
            serviceCollection.AddTransient<IProductService, ProductsService>();
            serviceCollection.AddTransient<IProductTypeService, ProductTypeService>();
            serviceCollection.AddTransient<IStateService, StateService>();
            serviceCollection.AddTransient<IPhoneService, PhoneService>();
            serviceCollection.AddTransient<IImagePathService, ImagePathService>();
        }
    }
}
