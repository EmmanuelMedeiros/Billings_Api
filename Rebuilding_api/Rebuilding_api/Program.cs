using Microsoft.EntityFrameworkCore;
using Rebuilding_api.Business;
using Rebuilding_api.Business.Implementation;
using Rebuilding_api.Context;
using Rebuilding_api.Repository;
using Rebuilding_api.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IBillingsRepositoryInterface, BillingsRepositoryImplementation>();
builder.Services.AddScoped<IBillingsBusinessInterface, BillingsBusinessImplementation>();

builder.Services.AddEndpointsApiExplorer();
var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
    connection,
    new MySqlServerVersion(new Version(8, 0, 29)))
);

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
