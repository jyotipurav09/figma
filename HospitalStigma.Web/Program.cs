using HospitalStigma.Data1;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
//Register Services
builder.Services.AddDbContext<HospitalDbContext>(options =>
    options.UseSqlServer(connection));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwagger();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
