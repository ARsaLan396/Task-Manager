using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;
using Task_Manager.Domain.Entities;

namespace Task_Manager.Application.Services.Task.Command.AddNewTask
{
    public class AddNewTaskService : IAddNewTaskService
    {
        private readonly IDatabaseContext _context;

        public AddNewTaskService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDtoNotData Execute(RequestAddnewTask request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Title) || string.IsNullOrEmpty(request.Description))
                {
                    return new ResultDtoNotData
                    {
                        IsSucsses = false,
                        Message = "لطفا تمامی فیلد ها را پر کنید."
                    };
                }

                TaskItem taskItem = new TaskItem
                {
                    Title = request.Title,
                    Description = request.Description,
                    IsCompleted = false,
                    CreatedDate = DateTime.Now,
                };

                _context.Tasks.Add(taskItem);
                _context.SaveChanges();

                return new ResultDtoNotData
                {
                    IsSucsses = true,
                    Message = "تسک مورد نظر با موفقیت اضافه شد."
                };

            }
            catch (Exception)
            {

                return new ResultDtoNotData
                {
                    IsSucsses = false,
                    Message = "تسک اضافه نشد."
                };
            }
        }
    }
}
