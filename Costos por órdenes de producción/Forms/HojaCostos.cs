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
    public partial class HojaCostos : Form
    {
        public Classes.Pedido pedido { get; set; }


        public HojaCostos(Classes.Pedido elPedido)
        {
            InitializeComponent();
            pedido = elPedido;
            textBox2.Text = pedido.numeroPedido+"";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TablaManoObra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
