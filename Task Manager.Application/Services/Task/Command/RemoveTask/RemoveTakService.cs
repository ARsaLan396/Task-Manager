using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Task.Command.RemoveTask
{
    public class RemoveTakService : IRemoveTakService
    {
        private readonly IDatabaseContext _context;

        public RemoveTakService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDtoNotData Execute(long id)
        {
            var task = _context.Tasks.Find(id);

            if (task == null)
            {
                return new ResultDtoNotData
                {
                    IsSucsses = false,
                    Message = "تسک مورد نظر یافت نشد."
                };
            }

            task.RemovedTime = DateTime.Now;
            task.IsRemoved = true;
            _context.SaveChanges();

            return new ResultDtoNotData
            {
                IsSucsses = true,
                Message = "تسک مورئ نظر با موفقیت حذف شد."
            };
        }
    }
}
