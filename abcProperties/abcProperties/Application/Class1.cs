using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    //This class will pass our dependency injection to the infrastructure layer, and will be called in the Program.cs file
    public static class StartUp
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            // We need the assembly so that MediatR and FluentValidation
            // know where to look for these classes.
            var assembly = Assembly.GetExecutingAssembly();
            //regiger Mediater Configuration(cfg) to the dependancy injection container
            //We arer registering from assembly of the StartUp class, which is in the Application layer
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);
            } )


            // Register application services here
            return services;
        }

    }
}
