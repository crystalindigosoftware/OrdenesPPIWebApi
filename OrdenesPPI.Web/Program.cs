using Microsoft.EntityFrameworkCore;
using OrdenesPPI.Infrastructure.Data;
using OrdenesPPI.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// CREATE STARTUP INSTANCE
var startup = new Startup(builder.Configuration);

// CONFIGURE SERVICES 
startup.ConfigureServices(builder.Services);
// Add services to the container.

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

/* CONFIGURE LIFETIME */
startup.Configure(app, app.Lifetime);

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//    app.UseSwaggerUI(config =>
//    {
        
//        config.RoutePrefix = ""; //para evitar problemas con la ruta en la que se lanza ...
//    });
//}

app.UseSwagger();
app.UseSwaggerUI();
app.UseSwaggerUI(config =>
{
    config.RoutePrefix = ""; //para evitar problemas con la ruta en la que se lanza ...
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

