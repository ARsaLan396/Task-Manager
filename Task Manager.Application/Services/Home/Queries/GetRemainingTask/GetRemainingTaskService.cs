using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Home.Queries.GetRemainingTask
{
    public class GetRemainingTaskService : IGetRemainingTaskService
    {
        private readonly IDatabaseContext _context;
        public GetRemainingTaskService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<int> Execute()
        {
            var tasks = _context.Tasks.Count(p => !p.IsCompleted);


            return new ResultDto<int>
            {
                Data = tasks,
                IsSucsses = true,
                Message = ""
            };
        }
    }
}
