using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
   internal class Pedido
   {
      public int PedidoId { get; set; }
      public int ClienteId { get; set; }
      public DateTime FechaPedido { get; set; } = DateTime.Now;
      public decimal Total { get; set; }
      public string Estado { get; set; }

      public Cliente Cliente { get; set; }

   }
}