using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    public class Operario
    {
        public String name { get; set; }
        public String tipo { get; set; }
        public String id { get; set; }

        public int horasTrabajadas { get; set; }

        public double totalValue { get; set; }

        public double valorUnitario { get; set; }

        public Operario(String n, String  i, String t)
        {
            name = n;
            id = i;
            tipo = t;
            horasTrabajadas = 0;
            totalValue = 0;
            valorUnitario = 0;
        }
    }
}
