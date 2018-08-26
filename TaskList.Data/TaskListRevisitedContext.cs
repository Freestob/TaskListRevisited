using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Domain.Models;
using TaskList.Data.Maps;
using System.Data.Entity;

namespace TaskList.Data
{
    public class TaskListRevisitedContext : DbContext
    {
        public TaskListRevisitedContext(): base("TaskList")
        {
            //Drop the database and recreate on each run
            //Database.SetInitializer(new DropCreateDatabaseAlways<GrandCircusLmsContext>());
            // Create the DB if it doesn't exist.  
            //Database.SetInitializer(new CreateDatabaseIfNotExists<GrandCircusLmsContext>());
            //Will Drop and recreate if model changes.
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GrandCircusLmsContext>());
            //Custom Initializer
            Database.SetInitializer(new TaskListRevisitedInitializer());
        }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ToDoMap());
            modelBuilder.Configurations.Add(new UserMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
