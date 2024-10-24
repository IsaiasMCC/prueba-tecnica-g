# Task App

## Descripción

Task App es una aplicación de consola simple para gestionar tareas. Permite a los usuarios agregar, eliminar y ver tareas mediante un menú interactivo. La aplicación también expone una API REST para gestionar las tareas.

## Características

- Agregar nuevas tareas.
- Eliminar tareas existentes.
- Ver todas las tareas.
- Interfaz de menú en la consola.
- API REST para la gestión de tareas.

## Requisitos

- [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) o superior.

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/IsaiasMCC/prueba-tecnica-g.git
   ```
2. Restaura las dependencias:
  ```bash
   dotnet restore
   ```
3. Compila el proyecto:
    ```bash
   dotnet build
   ```
5. Ejecuta la aplicación:
     ```bash
   dotnet run
   ```
## Uso de la API
La aplicación expone una API REST para gestionar tareas. Puedes hacer solicitudes a los siguientes endpoints:
- POST /tareas: Para añadir una nueva tarea.
- DELETE /tareas/{id}: Para eliminar una tarea.
- PUT /tareas/{id}: Para marcar una tarea como completada.
- GET /tareas: Para listar todas las tareas pendientes.
- GET /tareas/{id}: Para obtener los detalles de una tarea específica.
  ```bash
  {
    "name": "Nombre de la tarea"
  }
  ```
## Observaciones
En la aplicación se ejecutan la app tipo consola y un servidor web que sirve una api rest. cuando se finaliza el menú, el servidor web sigue ejecutandose. para volver a usar el menú se debera cerrar la ventana y correr nuevamente. 
por el motivo de que ambos se ejecuten al mismo tiempo.
  
