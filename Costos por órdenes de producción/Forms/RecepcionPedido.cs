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
    public partial class RecepcionPedido : Form
    {
        public int numeroPedido { get; set; }
        public RecepcionPedido(int numPedido)
        {
            InitializeComponent();
            numeroPedido = numPedido;
        }

        private void RecepcionPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
