using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_gestion_empleados_poo.Models;

namespace sistema_gestion_empleados.Models;

public class Empleado: Persona 
{
    public Guid Id { get; set; }
    
    public string NumeroDeIdentificacion { get; set; }
    
    public string Posicion { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string posicion, double salario):base(nombre, apellido, edad)
    {
        Id = new Guid();
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }

    private double CalcularBonificacion()
    {
        return Salario * 0.1;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"la imformación del empleado es la siguiente: {Nombre}, {Apellido}, {Edad}, {Posicion}, {Salario + CalcularBonificacion()}");
    }
}
