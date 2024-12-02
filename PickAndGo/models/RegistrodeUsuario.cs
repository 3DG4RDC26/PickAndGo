using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
    internal class RegistrodeUsuario
    {
        private const string archivoClientes = "clientes.txt";

        public void RegistrarCliente(Cliente cliente)
        {
            if (!File.Exists(archivoClientes))
            {
                File.Create(archivoClientes).Close();
            }

            if (ClienteExiste(cliente.CedulaCif))
            {
                throw new Exception("La cédula ya está registrada.");
            }
            using (StreamWriter sw = new StreamWriter(archivoClientes, append: true))
            {
                sw.WriteLine($"{cliente.CedulaCif}|{cliente.Nombre}|{cliente.Contraseña}|{cliente.Telefono}|{cliente.FechaRegistro}");
            }
        }

        public bool ClienteExiste(int cedulaCif)
        {
            if (!File.Exists(archivoClientes)) return false;

            string[] lineas = File.ReadAllLines(archivoClientes);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (int.Parse(datos[0]) == cedulaCif)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidarCliente(int cedulaCif, string contraseña)
        {
            if (!File.Exists(archivoClientes)) return false;

            string[] lineas = File.ReadAllLines(archivoClientes);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (int.Parse(datos[0]) == cedulaCif && datos[2] == contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Cliente> ObtenerClientes()
        {
            var clientes = new List<Cliente>();
            if (!File.Exists(archivoClientes)) return clientes;

            string[] lineas = File.ReadAllLines(archivoClientes);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                clientes.Add(new Cliente
                {
                    CedulaCif = int.Parse(datos[0]),
                    Nombre = datos[1],
                    Contraseña = datos[2],
                    Telefono = datos[3],
                    FechaRegistro = DateTime.Parse(datos[4])
                });
            }
            return clientes;
        }
    }
}