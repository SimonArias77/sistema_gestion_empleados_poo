using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados_poo.Models;

    public class Cliente: Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, byte edad, string email, string telefono):base(nombre, apellido, edad)
        {
            Email = email;
            Telefono = telefono;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"La información del cliente es la siguiente: {Nombre}, {Apellido}, {Edad}, {Email}, {Telefono}");
        }
    }
