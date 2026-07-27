using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Common.Dtos
{
    public class ResultDto<T>
    {
        public bool IsSucsses { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}
