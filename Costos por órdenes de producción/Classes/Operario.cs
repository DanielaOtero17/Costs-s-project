using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    class Operario
    {
        
        public String name { get; set; }
        public TipoLabor tipo { get; set; }
        public String id { get; set; }

       public Operario(String n, String  i, TipoLabor t)
        {
            name = n;
            id = i;
            tipo = t;
        }
    }
}
