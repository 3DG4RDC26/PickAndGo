using PickAndGo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Dao
{
    internal class ClienteDao
    {
        private List<Cliente> clientes;

        public ClienteDao()
        {
            clientes = new List<Cliente>();
        }

        public void Agregar(Cliente cliente)
        {
            clientes.Add(cliente);
            GuardarArchivo();
        }

        public void Actualizar(Cliente cliente)
        {
            int index = clientes.FindIndex(item => item.CedulaCif == cliente.CedulaCif);

            if (index != -1)
            {
                clientes[index] = cliente;
            }
            GuardarArchivo();
        }

        public List<Cliente> Listar(string dato)
        {
            clientes.Clear();
            CargarArchivo();

            if (string.IsNullOrEmpty(dato))
            {
                return clientes;
            }

            return clientes.FindAll(item => item.Nombre.Contains(dato));
        }

        public void SetList(List<Cliente> list)
        {
            clientes = list;
        }

        public Cliente Buscar(int cedulaCif)
        {
            return clientes.Find(item => item.CedulaCif == cedulaCif);
        }

        public int BuscarIndex(int cedulaCif)
        {
            return clientes.FindIndex(item => item.CedulaCif == cedulaCif);
        }

        public void Eliminar(Cliente cliente)
        {
            clientes.Remove(cliente);
            GuardarArchivo();
        }

        public void OrdenarPorNombre()
        {
            clientes.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
        }

        public List<Cliente> OrdenarPorFechaRegistro()
        {
            clientes.Clear();
            CargarArchivo();
            clientes.Sort((x, y) => x.FechaRegistro.CompareTo(y.FechaRegistro));
            return clientes;
        }

        private void GuardarArchivo()
        {
            string rutaArchivo = "clientes.dat";
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (Cliente c in clientes)
                    {
                        escritor.Write(c.CedulaCif);
                        escritor.Write(c.Nombre.Length);
                        escritor.Write(c.Nombre.ToCharArray());
                        escritor.Write(c.Contraseña.Length);
                        escritor.Write(c.Contraseña.ToCharArray());
                        escritor.Write(c.Telefono.Length);
                        escritor.Write(c.Telefono.ToCharArray());
                        escritor.Write(c.FechaRegistro.ToBinary());
                    }
                }
            }
        }

        private void CargarArchivo()
        {
            string rutaArchivo = "clientes.dat";
            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while (archivo.Position != archivo.Length)
                    {
                        int cedulaCif = lector.ReadInt32();
                        int nombreTamaño = lector.ReadInt32();
                        char[] nombreArray = lector.ReadChars(nombreTamaño);
                        string nombre = new string(nombreArray);

                        int contraseñaTamaño = lector.ReadInt32();
                        char[] contraseñaArray = lector.ReadChars(contraseñaTamaño);
                        string contraseña = new string(contraseñaArray);

                        int telefonoTamaño = lector.ReadInt32();
                        char[] telefonoArray = lector.ReadChars(telefonoTamaño);
                        string telefono = new string(telefonoArray);

                        DateTime fechaRegistro = DateTime.FromBinary(lector.ReadInt64());

                        Cliente cliente = new Cliente
                        {
                            CedulaCif = cedulaCif,
                            Nombre = nombre,
                            Contraseña = contraseña,
                            Telefono = telefono,
                            FechaRegistro = fechaRegistro
                        };

                        clientes.Add(cliente);
                    }
                }
            }
        }
    }
}
