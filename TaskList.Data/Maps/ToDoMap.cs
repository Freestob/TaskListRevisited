using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TaskList.Domain.Models;

namespace TaskList.Data.Maps
{
    class ToDoMap : EntityTypeConfiguration<ToDo>
    {
        public ToDoMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TaskName)
                .HasMaxLength(10);
            Property(x => x.TaskDescription)
                .HasMaxLength(100);
            Property(x => x.DueDate);
            Property(x => x.IsComplete);
                
        }
    }
}
