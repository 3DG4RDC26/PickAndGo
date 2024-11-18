﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAndGo.Models
{
   internal class Cliente
   {
      public int CeculaCif { get; set; }
      public string Nombre { get; set; }
      public string Contraseña { get; set; }
      public string Telefono { get; set; }
      public DateTime FechaRegistro { get; set; } = DateTime.Now;
   }
}