using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Common.Dtos;

namespace Task_Manager.Application.Services.Task.Command.ToggleComplete
{
    public interface IToggleCompleteService
    {
        ResultDtoNotData Execute(RequestToggleComplete request);
    }
}
