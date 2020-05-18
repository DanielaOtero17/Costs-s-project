using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
     public class Pedido
    {
        public static String ESTADO_EN_PROCESO = "En producción";
        public static String ESTADO_TERMINADA = "Terminada";
        public static String ESTADO_VENDIDA = "Vendida";
        // Número de identificación del pedido
        public int numeroPedido { get; set; }
        // Cantidad del artículo a producir
        public int cantidad { get; set; }
        //Cliente que realiza el pedido
        public String cliente { get; set; }
        //Artículo que se va a producir
        public String articulo { get; set; }

        public DateTime fechaCreacion  { get;set; } 

        public RequisicionMaterial requisicion { get; set; }

        public double CIF_presupuestado { get; set; }

        public ManoDeObra trabajadores { get; set; }

        public CIF cif { get; set; }
        public String estado { get; set; }
        public int Horas_presupuestadas { get; set; }
        public double totalPedido { get; set; }

        public double totalCif { get; set; }

        public Pedido(int i, int cant, String cli, String art, DateTime fecha)
        {
            numeroPedido = i;
            cantidad = cant;
            fechaCreacion = fecha;
            articulo = art;
            cliente = cli;
            requisicion = null;
            CIF_presupuestado = 0;
            trabajadores = null;
            cif = null;
            estado = ESTADO_EN_PROCESO;
            Horas_presupuestadas = 0;
            totalPedido = 0;
            totalCif = 0;
        }

        public Boolean compareTo(String cliente, String entrada)
        {
            if (cliente.Equals(entrada))
            {
                return true;
            }
            return false;
        }

        public String cambiarEstado()
        {
            if (estado.Equals(ESTADO_EN_PROCESO))
            {
                estado = ESTADO_TERMINADA;
            }else if (estado.Equals(ESTADO_TERMINADA)){
                estado = ESTADO_VENDIDA;
            }
            return estado;
        }
    }
}
