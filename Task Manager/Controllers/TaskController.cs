
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Application.Services.Task.Command.AddNewTask;
using Task_Manager.Application.Services.Task.Command.EditeTask;
using Task_Manager.Application.Services.Task.Command.RemoveTask;
using Task_Manager.Application.Services.Task.Command.ToggleComplete;
using Task_Manager.Application.Services.Task.Queries;

namespace Task_Manager.Controllers
{
    public class TaskController : Controller
    {
        private readonly IAddNewTaskService _addNewTaskService;
        private readonly IGetTaskService  _getTaskService;
        private readonly IRemoveTakService _removeTakService;
        private readonly IEditTaskService _editTaskService;
        private readonly IToggleCompleteService _toggleCompleteService;

        public TaskController(IAddNewTaskService addNewTaskService , IGetTaskService getTaskService , IRemoveTakService removeTakService , IEditTaskService editTaskService, IToggleCompleteService toggleCompleteService)
        {
            _addNewTaskService = addNewTaskService;
            _getTaskService = getTaskService;
            _removeTakService = removeTakService;
            _editTaskService = editTaskService;
            _toggleCompleteService = toggleCompleteService;
        }

        public IActionResult Index()
        {
            return View(_getTaskService.Execute().Data);
        }

        [HttpPost]
        public IActionResult Add(RequestAddnewTask request)
        {
            return Json(_addNewTaskService.Execute(request));
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            return Json(_removeTakService.Execute(id));
        }

        [HttpPost]
        public IActionResult Update(long id , string title , string description)
        {
            return Json(_editTaskService.Execute(new RequestEditeTaskDto
            {
                id = id,
                Title = title,
                Description = description
            }));
        }

        [HttpPost]
        public IActionResult ToggleComplete(long id)
        {
            return Json(_toggleCompleteService.Execute(new RequestToggleComplete
            {
                Id = id,
            }));
        }
    }
}
