using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Upd8.MVC.Web.Services;
using Upd8.MVC.Web.Services.Interfaces;
using Upd8.MVC.Web.Utils;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IServiceMvcCliente, ServiceMvcCliente>();

builder.Services.AddHttpClient("clienteType", c =>
{
    var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    c.BaseAddress = new Uri(configuration.GetSection("ApiUrl:Cliente").Value);
});

// Add services to the container.
builder.Services.AddControllersWithViews();


var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new DtoMappingProfile());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
