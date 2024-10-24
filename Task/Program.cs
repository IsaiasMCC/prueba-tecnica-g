using Task.Datas;
using Task.Presentation;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

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

        // Ejecutar la API
        app.Run();
    }
}