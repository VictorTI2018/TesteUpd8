using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Upd8.Infra.CrossCutting.IOC;
using Upd8.Infra.Data.Context;
using Upd8.Infra.Shared.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Conex�o com o banco de dados
var connection = builder.Configuration.GetConnectionString("SqlConnectionString");
builder.Services.AddDbContext<SqlContext>(options =>
{
    options.UseSqlServer(connection);
});
#endregion Conex�o com o banco de dados

#region Configurando dependencias do projeto
builder.Services.AddRepositoryDependency();
builder.Services.AddServiceDependency();
#endregion Configurando dependencias do projeto

#region Mapper

var configuration = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new DtoMappingProfile());
});

IMapper mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion Mapper

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
