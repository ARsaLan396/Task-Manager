using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Domain.Common;

namespace Task_Manager.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        [MaxLength(100)]
        public string? Title { get; set; }
        [MinLength(50)]
        [MaxLength(500)]
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public required DateTime CreatedDate { get; set; }
    }
}
