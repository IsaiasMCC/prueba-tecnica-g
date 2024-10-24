using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Bussines;
using Task.Datas;
using Task.API.Dto;

namespace Task.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private NTask task;
        private string filePath = "task.json";
        public TaskController()
        {
            task = new NTask();
            if (Serialize.ExistFile(filePath))
            {
                task = Serialize.Load<NTask>(filePath);
            }
        }     

        //  Para añadir una nueva tarea.
        [HttpPost]
        public IActionResult AddTask([FromBody] RequestTask request)
        {
            TaskModel newTask = new TaskModel(request.Name);
            task.add(newTask);
            Serialize.Save(task, filePath);
            return new JsonResult(new { message = "Tarea agregada con éxito" });
        }

    }
}
