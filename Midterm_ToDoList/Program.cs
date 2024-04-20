using Microsoft.EntityFrameworkCore;
using ToDo.Domain;
using System;
using ToDo.Repository;
using ToDo.Services;
using Midterm_ToDoList.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<NAppDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-TAHDD9J\\SQLEXPRESS01;Database=dbToDO;Trusted_Connection=True;TrustServerCertificate=True");// <----- Put connection String Here
});

builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase(databaseName: "InMemoryDb"));
builder.Services.AddSingleton<IToDoRepository, ToDoRepository>();
builder.Services.AddScoped<IToDoService, ToDoService>();
builder.Services.AddScoped<ToDoController>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ToDo}/{action=Index}/{id?}");

app.Run();
