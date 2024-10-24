using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Bussines
{
    public class TaskModel
    {
        public TaskModel(string Name) 
        {
            this.Id = 0;
            this.Name = Name;
            this.State = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }

    }
}
