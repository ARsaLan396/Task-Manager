
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Home.Queries.GetCompletedTask
{
    public interface IGetCompletedTaskService
    {
        ResultDto<int> Execute();
    }
}