using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Task.Command.EditeTask
{
    public interface IEditTaskService
    {
        ResultDtoNotData Execute(RequestEditeTaskDto request);
    }
}
