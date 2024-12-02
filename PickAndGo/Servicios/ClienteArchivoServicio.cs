using PickAndGo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Servicios
{
    internal class ClienteArchivoServicio
    {
        public void GuardarArchivo(List<Cliente> clientes, string rutaArchivo)
        {
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (Cliente cliente in clientes)
                    {
                        escritor.Write(cliente.CedulaCif);
                        escritor.Write(cliente.Nombre.Length);
                        escritor.Write(cliente.Nombre.ToCharArray());
                        escritor.Write(cliente.Contraseña.Length);
                        escritor.Write(cliente.Contraseña.ToCharArray());
                        escritor.Write(cliente.Telefono.Length);
                        escritor.Write(cliente.Telefono.ToCharArray());
                        escritor.Write(cliente.FechaRegistro.ToBinary());
                    }
                }
            }
        }
    }
}