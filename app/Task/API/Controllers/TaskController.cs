using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApp.API.Dto;
using TaskApp.Bussines;
using TaskApp.Datas;

namespace TaskApp.API.Controllers
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

        // Para eliminar una tarea.
        [HttpDelete("{id}")]
        public JsonResult DeleteTask(int id)
        {
            task.remove(id);
            Serialize.Save(task, filePath);
            return new JsonResult(new { message = "Tarea eliminada con éxito" });
        }

        // Para marcar una tarea como completada.
        [HttpPatch("{id}")]
        public JsonResult UpdateTask(int id)
        {
            task.changeCompreteTask(id);
            Serialize.Save(task, filePath);
            return new JsonResult(new { message = "Tarea marcada con éxito" });
        }

        // Para listar todas las tareas pendientes.
        [HttpGet]
        public JsonResult GetTasks()
        {
            return new JsonResult(task.getPendingTask());
        }

        // Para obtener los detalles de una tarea específica.
        [HttpGet("{id}")]
        public JsonResult GetTaskById(int id)
        {
            return task.get(id) != null ? new JsonResult(task.get(id)) : new JsonResult(new { message = "No existe tarea con este id" });
        }
    }
}
