using _05EJEM_API_EMPLEADOS_CORE.Data;
using _05EJEM_API_EMPLEADOS_CORE.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


String? cadenaconexion = builder.Configuration.GetConnectionString("cadenahospitalazure");

builder.Services.AddTransient<RepositoryEmpleados>();

builder.Services.AddDbContext<EmpleadosContext>(options =>
options.UseSqlServer(cadenaconexion));







builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



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
