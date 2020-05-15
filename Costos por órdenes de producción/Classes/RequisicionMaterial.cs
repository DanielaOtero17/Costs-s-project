using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    class RequisicionMaterial
    {
    
        public List<Material> materiales { get; set; }
        public int numero_pedido { get; set; }

        public RequisicionMaterial(int numPedido, List<Material> mate)
        {
            numero_pedido = numPedido;
            materiales = mate;
        }

    }
}
