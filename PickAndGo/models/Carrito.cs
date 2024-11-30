using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
        public class Carrito
        {
            // Lista para almacenar las comidas en el carrito
            public List<Comida> Productos { get; private set; }

            public Carrito()
            {
                Productos = new List<Comida>();
            }

            // Método para agregar una comida al carrito
            public void AgregarComida(Comida comida)
            {
                Productos.Add(comida);
            }

            // Método para obtener el total del carrito (por ejemplo, sumando los precios de los productos)
            public double ObtenerTotal()
            {
                double total = 0;
                foreach (var comida in Productos)
                {
                    total += comida.Precio;
                }
                return total;
            }
        }
}
