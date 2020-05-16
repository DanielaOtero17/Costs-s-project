using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
   public class Articulo
    {
        public String name { get; set; }
        public String description { get; set; }
        public int number { get; set; }

        public Articulo(String n, String desc, int num)
        {
            name = n;
            description = desc;
            number = num;
        }


    }
}
