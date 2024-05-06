using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using MudBlazor.Services;
using SMSS.Web.Data;
using SMSS.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();


builder.Services.AddHttpClient<IStaffService, StaffService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/");
});
builder.Services.AddHttpClient<ICommonService, CommonService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/");
});
builder.Services.AddHttpClient<IClassService, ClassService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/");
});
builder.Services.AddHttpClient<ISubjectService, SubjectService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/");
});
builder.Services.AddHttpClient<IStudentService, StudentService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/");
});

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
