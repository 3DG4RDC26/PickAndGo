using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
        public class Carrito
        {
            
            public List<Comida> Productos { get; private set; }

            public Carrito()
            {
                Productos = new List<Comida>();
            }

        public void Limpiar()
        {
            Productos.Clear(); 
        }


        public void AgregarComida(Comida comida)
            {
                Productos.Add(comida);
            }

            
            public double ObtenerTotal()
            {
            return Productos.Any() ? Productos.Sum(comida => comida.Precio) : 0;
        }
        }
}
