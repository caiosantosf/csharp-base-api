using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using BaseAPI.Infrastructure.CrossCutting.IOC;
using BaseAPI.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new ModuleIOC()));

builder.Services.AddDbContext<SqlServerContext>(opts =>
{
  var connString = builder.Configuration.GetConnectionString("SqlConnection:SqlConnectionString");
  opts.UseSqlServer(connString);
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo
  {
    Title = "API Model DDD",
    Version = "v1",
  });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(c =>
  {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Model DDD");
  });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
