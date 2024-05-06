using Microsoft.EntityFrameworkCore;
using SMSS.Api.Data;
using SMSS.Api.Models.Interface;
using SMSS.Api.Models.Repository;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews()
     .AddJsonOptions(options =>
     options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddScoped<IClassDetailsService, ClassDetailsRepository>(); 
builder.Services.AddScoped<ICommonService, CommonRepository>(); 
builder.Services.AddScoped<ISectionDetailsService, SectionDetailsRepository>();     
builder.Services.AddScoped<IStaffDetailsService, StaffDetailsRepository>();         
builder.Services.AddScoped<IStudentDetailsService, StudentDetailsRepository>();             
builder.Services.AddScoped<ISubjectService, SubjectRepository>();       

builder.Services.AddDbContext<SMSSContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SMSSConnection")));



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
