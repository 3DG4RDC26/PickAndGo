﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
   internal class Menú
   {
      public int MenuId { get; set; }
      public string Nombre { get; set; }
      public string Descripcion { get; set; }
      public decimal Precio { get; set; }
      public bool Disponible { get; set; } = true;
   }
}