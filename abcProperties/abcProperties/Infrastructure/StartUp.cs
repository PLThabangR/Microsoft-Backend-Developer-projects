using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    //We register our dependencies in this class, so we can use them in our application
    public static class StartUp
    {
        //We gonna configuration to get our connection string from appsettings.json file, so we need to add it as a parameter in this method
        //THis IServiceCollection is a not a parameter is an extension method, so we can use it in the Program.cs file to register our dependencies
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,IConfiguration configuration) {

            // Get the connection string from appsettings.json
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Make sure the connection string exists
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException(
                    "Connection string 'DefaultConnection' not found in configuration.");
            }

            //Register DbContext 
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                //We will use SQL Server as our database provider
                options.UseSqlServer(connectionString, sqlOptions =>
                {   /// Rename the EF core tabble to "Migrations" and place it in the "EFCore" schema 
                    // Store EF Core migrations history in a custom table/schema
                    sqlOptions.MigrationsHistoryTable("Migrations", "EFCore");

                    // Retry the SQL Server operation if a temporary connection
                    // failure occurs
                    sqlOptions.EnableRetryOnFailure();
                } 
                
               );

            }
            
            );


            // Register other infrastructure services here
            return services;
        }

    }
}
