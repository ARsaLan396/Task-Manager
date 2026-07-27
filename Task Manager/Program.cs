using Microsoft.EntityFrameworkCore;
using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Application.Services.Home.Queries.GetCompletedTask;
using Task_Manager.Application.Services.Home.Queries.GetRemainingTask;
using Task_Manager.Application.Services.Home.Queries.GetTotalTask;
using Task_Manager.Application.Services.Task.Command.AddNewTask;
using Task_Manager.Application.Services.Task.Command.EditeTask;
using Task_Manager.Application.Services.Task.Command.RemoveTask;
using Task_Manager.Application.Services.Task.Command.ToggleComplete;
using Task_Manager.Application.Services.Task.Queries;
using Task_Manager.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//DI TASK
builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
builder.Services.AddScoped<IAddNewTaskService, AddNewTaskService>();
builder.Services.AddScoped<IGetTaskService, GetTaskService>();
builder.Services.AddScoped<IRemoveTakService, RemoveTakService>();
builder.Services.AddScoped<IEditTaskService, EditTaskService>();
builder.Services.AddScoped<IToggleCompleteService, ToggleCompleteService>();

//DI HOME
builder.Services.AddScoped<IGetTotalTaskService, GetTotalTaskService>();
builder.Services.AddScoped<IGetCompletedTaskService, GetCompletedTaskService>();
builder.Services.AddScoped<IGetRemainingTaskService, GetRemainingTaskService>();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
