using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    public class CIF
    {
        public int numeroPedido { get; set; }
        public double cif_presupuestado { get; set; }
        public int horas_presupuestadas { get; set; }

        public CIF(int numPed,double cifpre,int horasp)
        {
            numeroPedido = numPed;
            cif_presupuestado = cifpre;
            horas_presupuestadas = horasp;

        }

    }
}
