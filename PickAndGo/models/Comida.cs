using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
        public class Comida
        {
            public int IdComida { get; set; }
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; } 

            public Comida(int idComida, string nombre, double precio, int cantidad = 1)
            {
                IdComida = idComida;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }

            public override string ToString()
            {
                return $"{Nombre} - ${Precio}";
            }
        }
}


