using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }

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

    public void BuscarEmpleado(string numeroDeIdentificacion)
    {
        var emp = ListaEmpleados.Where(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);

    }

    public bool ActualizarEmpleado(string numeroDeIdentificacion, string nuevoNombre, string nuevoApellido, byte nuevaEdad, string nuevaPosicion, double nuevoSalario)
    {
        //encontrar empleado con numero de identifiacion dado
        Empleado empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        
        if (empleado == null)
        {
            //empleado no encontrado
            return false;
        }

        //actualiza la informacion del empleado
        empleado.Nombre = nuevoNombre;
        empleado.Apellido =nuevoApellido;

        return true;
    }

}
