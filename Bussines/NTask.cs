﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Bussines
{
    public class NTask
    {
        public NTask() 
        {
            Tasks = new List<TaskModel>();
        }
        public List<TaskModel> Tasks { get; set; }

        public void add(TaskModel task)
        {
            task.Id = Tasks.Count() + 1;
            Tasks.Add(task);
        }



    }
}
