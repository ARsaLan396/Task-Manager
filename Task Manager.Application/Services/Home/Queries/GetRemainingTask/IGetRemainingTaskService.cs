using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Home.Queries.GetRemainingTask
{
    public interface IGetRemainingTaskService
    {
        ResultDto<int> Execute();
    }
}
