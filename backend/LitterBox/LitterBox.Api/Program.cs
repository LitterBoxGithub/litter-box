using LitterBox.Api.Data;
using LitterBox.Api.Data.Repositories;
using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Services;
using LitterBox.Api.Services.Interfaces;
using LitterBox.Api.SignalR.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddSignalR();
builder.Services.AddControllers();

builder.Services.AddDbContextPool<LitterBoxContext>(options =>
{
    var connectionString = config.GetConnectionString("LitterBox");
    options.UseNpgsql(connectionString);
});

builder.Services
    .AddLogging()
    .AddScoped<IPetService, PetService>()
    .AddScoped<IUserService, UserService>()
    .AddScoped<IPetRepository, PetRepository>()
    .AddScoped<IUserRepository, UserRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Litter Box",
            Description = "API",
            Version = "v1",
        });

    c.UseInlineDefinitionsForEnums();
    c.UseAllOfToExtendReferenceSchemas();
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.MapHub<LitterBoxHub>("/litter-box-hub");

app.Run();
