using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Domain.Common
{
    public class BaseEntity<TKey>
    {
        [Key]
        public  TKey? Id { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime? RemovedTime { get; set; }
    }

    public class BaseEntity : BaseEntity<long>
    {

    }
}
