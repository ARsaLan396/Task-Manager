using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Home.Queries.GetTotalTask
{
    public class GetTotalTaskService : IGetTotalTaskService
    {
        private readonly IDatabaseContext _context;
        public GetTotalTaskService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<int> Execute()
        {
            var totalTask = _context.Tasks.Count();

            return new ResultDto<int>
            {
                Data = totalTask,
                IsSucsses = true,
                Message = ""
            };
        }
    }
}
