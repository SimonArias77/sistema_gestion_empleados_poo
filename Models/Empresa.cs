using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_gestion_empleados_poo.Models;

namespace sistema_gestion_empleados.Models;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }
    public List<Cliente> ListaClientes { get; set; }

    public Empresa(string nombre, string direccion, List<Empleado> listaEmpleados)
    {
        Nombre = nombre;
        Direccion = direccion;
        ListaEmpleados = listaEmpleados;
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);

    }

    public void EliminarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Remove(empleado);
    }

    public void MostrarTodosLosEmpleados()
    {
        foreach (Empleado empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }


    public Empleado BuscarEmpleado(string numeroDeIdentificacion)
    {
        return ListaEmpleados.Where(e => e.NumeroDeIdentificacion == numeroDeIdentificacion).FirstOrDefault();

    }

    public void ActualizarEmpleado(string numeroDeIdentificacion, string nuevoNombre, string nuevoApellido, byte nuevaEdad, string nuevaPosicion, double nuevoSalario)
    {
        //encontrar empleado con numero de identifiacion dado
        Empleado empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);

        if (empleado == null)
        {
            Console.WriteLine("el empleado no fué encontrado");
        }

        else
        {
            //actualiza la informacion del empleado
            empleado.NumeroDeIdentificacion = numeroDeIdentificacion;
            empleado.Nombre = nuevoNombre;
            empleado.Apellido = nuevoApellido;
            empleado.Edad = nuevaEdad;
            empleado.Posicion = nuevaPosicion;
            empleado.Salario = nuevoSalario;

            Console.WriteLine("el empleado ha sido actualizado con éxito");

        }
    }

    public void MostrarEmpleadosPorCargo(string posicion)
    {
        var empleado = ListaEmpleados.Where(e => e.Posicion == posicion).ToList();

        if (empleado == null)
        {
            Console.WriteLine($"el{posicion} no fué encontrado");
        }
        else
        {
            Console.WriteLine($"los empleados con el cargo {posicion} son los siguientes:");
            foreach (var item in empleado)
            {
                item.MostrarInformacion();
            }
        }
    }
}
