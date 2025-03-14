using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Task
    {
        protected string Description;

        public Task()
        {
            this.SetDescription("Default task");
        }
        public Task(string Description)
        {
            this.SetDescription(Description);
        }
        public string GetDescription() { 
            return this.Description;
        }
        public void SetDescription(string Discription)
        {
            this.Description = Discription;
        }
        public void DisplayTask()
        {
            Console.WriteLine(GetDescription());
        }
    }
}
