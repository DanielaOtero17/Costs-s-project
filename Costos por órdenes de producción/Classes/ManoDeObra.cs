using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    public class ManoDeObra
    {
        public int numPedido { get; set; }
        public List<Operario> trabajadores { get; set; }

        public double totalValue;

        public ManoDeObra(int numeroPedido,List<Operario> operarios) 
        {
            numPedido = numeroPedido;
            trabajadores = operarios;
            totalValue = 0;
        }
    }

    
}
