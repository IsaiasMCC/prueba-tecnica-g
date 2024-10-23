using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Bussines;

namespace Task.Presentation
{
    public class Presentation
    {
        public NTask task;

        public Presentation() 
        {
            task = new NTask();
        }
        public void AddTask()
        {
            Console.WriteLine("\n");
            Console.Write("Nombre de Tarea: ");
            string taskName = Console.ReadLine();
            task.add(new TaskModel(taskName));
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
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            AddTask();
                            break;
                        case 4:
                            
                            break;
                        case 5:
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

            } while (option != 5);
        }

       
    }
}
