using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Domain.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }

    }
}
