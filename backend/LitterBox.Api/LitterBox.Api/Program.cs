using LitterBox.Api.Data;
using LitterBox.Api.Data.Repositories;
using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Services;
using LitterBox.Api.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Grab configuration variables from appsettings.json
var config = builder.Configuration;

// DB Setup
builder.Services.AddDbContextPool<LitterBoxContext>(options =>
{
    var connectionString = config.GetConnectionString("LitterBox");
    options.UseNpgsql(connectionString);
});

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddLogging()
    .AddScoped<IPetService, PetService>()
    .AddScoped<IUserService, UserService>()
    .AddScoped<IPetRepository, PetRepository>()
    .AddScoped<IUserRepository, UserRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
    });
});


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

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
