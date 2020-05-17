using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costos_por_órdenes_de_producción.Forms
{
    public partial class CostosIndirectos : Form
    {

        public  RecepcionPedido recepcion {get;set;}
        public CostosIndirectos(RecepcionPedido recep)
        {
            InitializeComponent();
            recepcion = recep;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
