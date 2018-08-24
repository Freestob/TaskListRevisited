using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TaskList.Domain.Models;


namespace TaskList.Data
{
    class TaskListRevisitedInitializer :CreateDatabaseIfNotExists<TaskListRevisitedContext>
    {
        protected override void Seed(TaskListRevisitedContext context)
        {
            var user = new User()
            {
                UserName = "Freestob",
                Email = "bradley.freestone@gmail.com",
                Password = "Password1"
            };
            context.Users.Add(user);
            context.SaveChanges();

            var toDo = new ToDo()
            {
                TaskName = "Mow Lawn",
                TaskDescription = "Mow the lawn to 3.25 inches",
                DueDate = new DateTime(2018, 09, 01),
                IsComplete = false,
            };
            context.ToDos.Add(toDo);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
