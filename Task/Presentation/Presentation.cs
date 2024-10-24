using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Bussines;
using Task.Datas;

namespace Task.Presentation
{
    public class Presentation
    {
        public NTask task;

        public Presentation() 
        {
            string filePath = "task.json";
            task = new NTask();
            if (Serialize.ExistFile(filePath))
            {
                task = Serialize.Load<NTask>(filePath);
            }
        }
        public void AddTask()
        {
            Console.WriteLine("\n");
            Console.Write("Nombre de Tarea: ");
            string taskName = Console.ReadLine();
            task.add(new TaskModel(taskName));
        }

        public void RemoveTask()
        {
            Console.WriteLine("\n");
            Console.Write("ID de la Tarea a eliminar: ");
            int taskId = int.Parse(Console.ReadLine());
            task.remove(taskId);
        }

        public void changeCompleteTask()
        {
            Console.WriteLine("\n");
            Console.Write("ID de la Tarea para marcar como hecha: ");
            int taskId = int.Parse(Console.ReadLine());
            task.changeCompreteTask(taskId);
        }
        public void showPendingTask()
        {
            Console.WriteLine("\nTareas Pendientes:");
            showHeadTask();
            string tableFooter = "╚═══════╩════════════════════════╝";
            foreach (TaskModel task in task.Tasks.Where(task => !(task.State)))
            {
                string row = $"║ {task.Id,-5} ║ {task.Name,-20} ";
                Console.WriteLine(row);
            }

            Console.WriteLine(tableFooter);
        }

        public void showCompleteTask()
        {
            Console.WriteLine("\nTareas Completadas:");
            showHeadTask();
            string tableFooter = "╚═══════╩════════════════════════╝";
            foreach (TaskModel task in task.Tasks.Where(task => (task.State)))
            {
                string row = $"║ {task.Id,-5} ║ {task.Name,-20} ║";
                Console.WriteLine(row);
            }

            Console.WriteLine(tableFooter);
        }

        public void showHeadTask()
        {
            string tableHeader = "╔═══════╦════════════════════════╗";
            string headerContent = "║  Id   ║        Nombre          ║";

            Console.WriteLine(tableHeader);
            Console.WriteLine(headerContent);
            Console.WriteLine("╠═══════╬════════════════════════╣");
        }

        public void ShowMenu()
        {
            int option = 0;
            do
            {
                // Menú con opciones 
                Console.WriteLine("\n===== MENÚ DE TAREAS =====");
                Console.WriteLine("1. Ver Tareas Pendientes");
                Console.WriteLine("2. Ver Tareas Completadas");
                Console.WriteLine("3. Agregar Tarea");
                Console.WriteLine("4. Eliminar Tarea");
                Console.WriteLine("5. Marcar tarea como completada");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una opción: ");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            showPendingTask();
                            break;
                        case 2:
                            showCompleteTask();
                            break;
                        case 3:
                            AddTask();
                            break;
                        case 4:
                            RemoveTask();
                            break;
                        case 5:
                            changeCompleteTask();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida, por favor intenta de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }

            } while (option != 6);
            //Guarda el archivo
            Serialize.Save<NTask>(task, "task.json");
        }

       
    }
}
