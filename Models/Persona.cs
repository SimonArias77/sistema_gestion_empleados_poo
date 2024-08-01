using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados_poo.Models;

    public class Persona
    {
        
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public byte Edad { get; set; }

    public Persona(string nombre, string apellido, byte edad)
    {
        Id = new Guid();
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"La información de la persona es la siguiente: {Nombre}, {Apellido}, {Edad}");
    }
    
    }
