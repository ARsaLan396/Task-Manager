using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Home.Queries.GetCompletedTask
{
    public class GetCompletedTaskService : IGetCompletedTaskService
    {
        private readonly IDatabaseContext _context;
        public GetCompletedTaskService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<int> Execute()
        {
            var tasks = _context.Tasks.Count(p => p.IsCompleted);
    

            return new ResultDto<int>
            {
                Data = tasks,
                IsSucsses = true,
                Message =  ""
            };
        }
    }
}
