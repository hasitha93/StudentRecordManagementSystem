using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentRecordManagementSystem.Application.Interfaces.Repositories;
using StudentRecordManagementSystem.Infrastructure.DbContexts;
using StudentRecordManagementSystem.Infrastructure.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var configurations = builder.Configuration;

// Add services to the container.

// register all Commands, Queries and Domain event handlers
builder.Services.AddMediatR(typeof(StudentRecordManagementSystem.Application.Queries.StudentList.GetStudentListQueryHandler).GetTypeInfo().Assembly);

builder.Services.AddDbContext<ReadOnlyDbContext>(options =>
            options.UseSqlServer(configurations.GetConnectionString("SqlServer")), ServiceLifetime.Scoped);

builder.Services.AddScoped<IStudentReadRepository, StudentReadRepository>();

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
