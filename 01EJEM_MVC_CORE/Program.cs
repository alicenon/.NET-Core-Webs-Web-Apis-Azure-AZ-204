using _01EJEM_MVC_CORE.Models;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<Coche>(); ////INYECTA EL COCHE
builder.Services.AddSingleton<Coche>();//PATRON -> EL  OBJETO SE CREA UNA SOLA VEZ.
builder.Services.AddSingleton<ICoche, Deportivo>();
builder.Services.AddSingleton<ICoche>(x => new Deportivo("ferrari", "Testarossa", "ferrari.jpg", 290));
// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
