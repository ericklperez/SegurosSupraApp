using Microsoft.OpenApi.Models;
using SupraSeguros.Persistence.Repositories.Contracts;
using SupraSeguros.Services.Customer.DbContexts;
using SupraSeguros.Services.Customer.Entities;
using SupraSeguros.Services.Customer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EventDto Catalog API", Version = "v1" });
});

builder.Services.AddScoped<IRepositoryAsync<Customer>, CustomerBaseRepository>();

builder.Services.AddPersistenceServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "EventDto Catalog API V1");

});

app.UseAuthorization();

app.MapControllers();

app.Run();
