using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apiclientes.modelos
{
   public class Clientes
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion {get; set;}

        internal static Clientes FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        internal class cs
        {
        }
    }
}