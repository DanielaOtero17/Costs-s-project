﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costos_por_órdenes_de_producción.Classes
{
    public class TipoLabor
    {
        public String name { get; set; }
        public double valuePerhour { get; set; }

        public TipoLabor(String n, double vph)
        {
            name = n;
            valuePerhour = vph;
        }

    }
}
