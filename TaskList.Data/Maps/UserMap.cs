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
     class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.ToDos)
                .WithRequired(x => x.User)
                .HasForeignKey(x => x.UserId);
            Property(x => x.UserName)
                .HasMaxLength(20)
                .IsRequired();
            Property(x => x.Email)
                .IsRequired();
            Property(x => x.Password)
                .HasMaxLength(7)
                .IsRequired();
            
        }
    }
}
