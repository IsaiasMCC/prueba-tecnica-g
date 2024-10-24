using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TaskApp.Presentation;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear un host web genérico
        var builder = WebApplication.CreateBuilder(args);

        // Agregar servicios para controladores
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configurar los endpoints de la API
        app.MapControllers();

        // HILO QUE MANEJA LA CONSOLA.
        Presentation presentation = new Presentation();
        Task.Run(() => presentation.ShowMenu());

        // Ejecutar la API
        app.Run();
    }
}