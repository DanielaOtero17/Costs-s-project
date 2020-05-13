using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    class Pedido
    {
        // Número de identificación del pedido
        public int numeroPedido { get; set; }
        // Cantidad del artículo a producir
        public int cantidad { get; set; }
        //Cliente que realiza el pedido
        public Cliente cliente { get; set; }
        //Artículo que se va a producir
        public Articulo articulo { get; set; }


        public Pedido(int i, Cliente cli, Articulo art, int cant)
        {
            numeroPedido = i;
            cantidad = cant;
            art = null;
            cli = null;
        }
    }
}
