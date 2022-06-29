using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Application;
using MovieManagement.Infrastructure;
using MovieManagement.Persistance;
using System.Configuration;
using System.Reflection;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure(Configuration);
builder.Services.AddPersistance(Configuration);
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MovieDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDatabase")));
builder.Services.AddHealthChecks();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
