using _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Models;
using _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

String? cadenaconexion = builder.Configuration.GetConnectionString("cadenahospitalazure");

builder.Services.AddTransient<RepositoryEmpleados>();

builder.Services.AddDbContext<EmpleadosContext>(options =>
options.UseSqlServer(cadenaconexion));



//
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//publicando con Swagger 

// 1.- Para servir la interfaz de usuario de Swagger en la raíz de la aplicación (https://localhost:<port>/), establezca la propiedad RoutePrefix en una cadena vacía:

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

// 2.- Indicar que soporte la versión 2.0 para dar soporte a Microsoft Power Apps y Microsoft Flow

app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
});

// 3.- Incluir la negación (!) a la condicional por defecto

if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Swagger end

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
