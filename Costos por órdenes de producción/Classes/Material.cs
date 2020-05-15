using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    public class Material
    {
        public String descripcion { get; set; }
        public int cantidad { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal { get; set; }

        public Material(String desc,int cant,double value,double valorT)
        {
            descripcion = desc;
            cantidad = cant;
            valorUnitario = value;
            valorTotal = valorT;

        }
    }
}
