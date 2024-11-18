using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public int Telefono { get; set; }
        public int Cif { get; set; }


        public Cliente(int idCliente, string nombre, int telefono, int cif)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono;
            Cif = cif;
            
        }

    }
}
