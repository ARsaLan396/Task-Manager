using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Application.Services.Home.Queries.GetCompletedTask;
using Task_Manager.Application.Services.Home.Queries.GetRemainingTask;
using Task_Manager.Application.Services.Home.Queries.GetTotalTask;
using Task_Manager.Models;

namespace Task_Manager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGetTotalTaskService _totalTask;
    private readonly IGetCompletedTaskService _getCompletedTask;
    private readonly IGetRemainingTaskService _getRemainingTask;

    public HomeController(ILogger<HomeController> logger , IGetTotalTaskService totalTask , IGetCompletedTaskService getCompletedTask , IGetRemainingTaskService getRemainingTask)
    {
        _logger = logger;
        _totalTask = totalTask;
        _getCompletedTask = getCompletedTask;
        _getRemainingTask = getRemainingTask;
    }

    public IActionResult Index()
    {
        HomeSummaryViewModel Summary = new HomeSummaryViewModel()
        {
            Total = _totalTask.Execute().Data,
            Completed = _getCompletedTask.Execute().Data,
            Remaining = _getRemainingTask.Execute().Data
        }; 
        return View(Summary);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
