using Microsoft.EntityFrameworkCore;
using Entrega1.DataAccess;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

const string CONNECTION_NAME = "Course";
string? connectionString = builder.Configuration.GetConnectionString(CONNECTION_NAME);

builder.Services.AddDbContext<CourseDBContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
