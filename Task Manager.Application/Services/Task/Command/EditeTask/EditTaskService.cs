using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Task.Command.EditeTask
{
    public class EditTaskService : IEditTaskService
    {
        private readonly IDatabaseContext _context;

        public EditTaskService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDtoNotData Execute(RequestEditeTaskDto request)
        {
            var task = _context.Tasks.Find(request.id);

            if (task == null)
            {
                return new ResultDtoNotData
                {
                    IsSucsses = false,
                    Message = "تسک مورد نظر یافت نشد."
                };
            }

            task.Title = request.Title;
            task.Description = request.Description;
            task.UpdateTime = DateTime.Now;
            _context.SaveChanges();

            return new ResultDtoNotData
            {
                IsSucsses = true,
                Message = "تسک با موفقیت ویرایش شد."
            };
        }
    }
}
