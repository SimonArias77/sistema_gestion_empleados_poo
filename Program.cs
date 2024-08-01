using System.Net.Mail;
using sistema_gestion_empleados.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Empleado> listaEmpleado = new List<Empleado>()
        {
            new Empleado("Simón", "Arias", "1152449763", 25, "supervisor", 2000000),
            new Empleado("Ana", "Gómez", "1167890123", 30, "Gerente", 3500000),
            new Empleado("Luis", "Martínez", "1145678901", 28, "Analista", 2500000),
            new Empleado("Marta", "Rodríguez", "1134567890", 35, "Administrativo", 2200000),
            new Empleado("Jorge", "Vásquez", "1198765432", 40, "Desarrollador", 3000000)
        };
        var empresa = new Empresa("ICA", "CARRERA 90 #32-15", listaEmpleado);
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Eliminar empleado");
            Console.WriteLine("3. Mostrar todos los empleados");
            Console.WriteLine("4. Buscar empleado");
            Console.WriteLine("5. Actualizar empleado");
            Console.WriteLine("6. Mostrar empleados por cargo");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("escriba el nombre del empleado");
                        var nombre = Console.ReadLine();
                        Console.WriteLine("escriba el apellido del empleado");
                        var apellido = Console.ReadLine();
                        Console.WriteLine("escriba el numero de documento del empleado");
                        var numeroDeIdentificacion = Console.ReadLine();
                        Console.WriteLine("escriba la edad del empleado");
                        byte edad = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("escriba el cargo o posición del empleado");
                        var posicion = Console.ReadLine();
                        Console.WriteLine("escriba el salario del empleado");
                        double salario = Convert.ToDouble(Console.ReadLine());

                        empresa.AgregarEmpleado(new Empleado(nombre, apellido, numeroDeIdentificacion, edad, posicion, salario));
                        break;

                    case 2:
                        Console.WriteLine("por favor digite el numero de identificación del empleado");
                        var nuevoNumeroDeIdentificacion = Console.ReadLine();
                        var buscarEmpleado = empresa.BuscarEmpleado(nuevoNumeroDeIdentificacion);
                        if (buscarEmpleado == null)
                        {
                            Console.WriteLine("el empleado no existe");
                        }
                        else
                        {
                            empresa.EliminarEmpleado(buscarEmpleado);
                        }
                        break;

                    case 3:
                        empresa.MostrarTodosLosEmpleados();
                        break;

                    case 4:
                        Console.WriteLine("por favor digite el número de identifiación del empleado que desea buscar");
                        var otroNumeroDeIdentificacion = Console.ReadLine();
                        var encontrarEmpleado = empresa.BuscarEmpleado(otroNumeroDeIdentificacion);
                        if (encontrarEmpleado == null)
                        {
                            Console.WriteLine("el empleado no está registrado en la empresa");
                        }
                        else
                        {
                            Console.WriteLine($"el empleado {encontrarEmpleado.Nombre} está registrado en la empresa");
                        }

                        break;

                    case 5:
                        Console.WriteLine("por favor digite el número de identificación del empleado a actualizar");
                        var elNumeroDeIdentificacion = Console.ReadLine();
                        var hallarEmpleado = empresa.BuscarEmpleado(elNumeroDeIdentificacion);
                        if (hallarEmpleado == null)
                        {
                            Console.WriteLine("el empleado no está registrado en la empresa");
                        }
                        else
                        {
                            Console.WriteLine("digite el nuevo nombre del empleado");
                            var nuevoNombre = Console.ReadLine();
                            Console.WriteLine("digite el nuevo apellido del empleado");
                            var nuevoApellido = Console.ReadLine();
                            Console.WriteLine("digite la nueva edad del empleado");
                            byte nuevaEdad = Convert.ToByte(Console.ReadLine());
                            Console.WriteLine("digite la nueva posición o cargo del empleado");
                            var nuevaPosicion = Console.ReadLine();
                            Console.WriteLine("digite el nuevo salario del empleado");
                            double nuevoSalario = Convert.ToDouble(Console.ReadLine());

                            empresa.ActualizarEmpleado(elNumeroDeIdentificacion, nuevoNombre, nuevoApellido, nuevaEdad, nuevaPosicion, nuevoSalario);
                        }

                        break;

                    case 6:
                        Console.WriteLine("ingrese el cargo  del empleado que desea mostrar ");
                        var otraPosicion = Console.ReadLine();
                        empresa.MostrarEmpleadosPorCargo(otraPosicion);
                        break;

                    case 7:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }

            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}

