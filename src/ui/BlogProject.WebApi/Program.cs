using BlogProject.Persistence.Configuration.Database;
using BlogProject.Persistence.Configuration.Repositories;
using BlogProject.Application.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Db config
builder.Services.ConfigureAppDatabase(builder.Configuration);

// Repositories config
builder.Services.ConfigureAppRepositories();

// Configure Services in App Layer
builder.Services.ConfigureServices();



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
