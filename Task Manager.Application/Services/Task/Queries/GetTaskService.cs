using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Task.Queries
{
    public class GetTaskService : IGetTaskService
    {
        private readonly IDatabaseContext _context;

        public GetTaskService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<GetTaskDto>> Execute()
        {
            var tasks = _context.Tasks.Select(p => new GetTaskDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                IsCompleted = p.IsCompleted,
                CreatedDate = p.CreatedDate
            }).ToList();

            return new ResultDto<List<GetTaskDto>>
            {
                Data = tasks,
                IsSucsses = true,
                Message = ""
            };
        }
    }
}
