using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    class Pedido
    {
        public String id { get; set; }


        public Pedido(String i)
        {
            id = i;
        }
    }
}
