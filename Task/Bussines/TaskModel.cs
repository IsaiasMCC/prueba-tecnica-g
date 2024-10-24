using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Bussines
{
    public class TaskModel
    {
        public TaskModel(string Name)
        {
            Id = 0;
            this.Name = Name;
            State = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }

    }
}
