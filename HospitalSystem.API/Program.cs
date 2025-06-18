using HospitalSystem.Application.Interfaces;
using HospitalSystem.Infrastructure.Context;
using HospitalSystem.Infrastructure.Repositories;
using HospitalSystem.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalDb;Integrated Security=True;"));

builder.Services.AddScoped<IPatientRepository,PatientRepository>();
builder.Services.AddScoped<IPatientService,PatientService>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();



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
