using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/*Add Infrastructure Services*/
//We must pass the configuration parameter to the AddInfrastructureService method, so we can get our connection string from appsettings.json file
//configurations are found within the builder .Configuration property, which is an instance of IConfiguration. This property is automatically populated with the configuration settings from various sources, including appsettings.json, environment variables, and command-line arguments. By passing builder.Configuration to the AddInfrastructureService method, we ensure that our infrastructure services have access to the necessary configuration settings, such as the database connection string.
builder.Services.AddInfrastructureService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
