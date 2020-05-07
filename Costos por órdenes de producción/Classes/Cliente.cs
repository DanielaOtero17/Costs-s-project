using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    class Cliente
    {
        public static String PERSONA_NATURAL = "Persona Natural";
        public static String PERSONA_JURIDICA = "Persona Juridica";
        private String name { get; set; }
        private String id { get; set; }
        private String tipo { get; set; }

        public Cliente(String n, String i, String t)
        {
            name = n;
            id = i;
            tipo = t;
        }

    }
}
