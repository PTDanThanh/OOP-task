using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class ToDoList
    {
        List<Task> tasks = new List<Task>();
        public void InsertTask(Task task)
        {
            tasks.Add(task);
        }
        public void DisplayTasks()
        {
            int i = 1;
            foreach (var item in tasks)
            {
                Console.WriteLine(i + ":");
                Console.WriteLine(item.GetDescription());
                i++;
            }
        }
        public Task UpdateTask(int i, string updateDescription)
        {
            tasks[i].SetDescription(updateDescription);
            return tasks[i];   
        }
        public void RemoveTask(int i)
        {
            tasks.RemoveAt(i);
        }
    }
}
