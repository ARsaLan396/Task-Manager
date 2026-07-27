using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Task.Command.ToggleComplete
{
    public class ToggleCompleteService : IToggleCompleteService
    {
        private readonly IDatabaseContext _context;

        public ToggleCompleteService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDtoNotData Execute(RequestToggleComplete request)
        {
            var task = _context.Tasks.Find(request.Id);

            if (task == null)
            {
                return new ResultDtoNotData
                {
                    IsSucsses = false,
                    Message = "تسک مورد نظر یافت نشد."
                };
            }

            task.IsCompleted = !task.IsCompleted;
            _context.SaveChanges();

            return new ResultDtoNotData
            {
                IsSucsses = true,
                Message = task.IsCompleted ? "✅ عالی بود! یکی دیگه از لیست خارج شد." : 
                "⏳ باشه، بذاریمش رو حالت در حال انجام."
            };
        }
    }
}
