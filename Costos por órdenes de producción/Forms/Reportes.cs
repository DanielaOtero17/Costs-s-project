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
    public partial class Reportes : Form
    {
        
        private List<Classes.Pedido> pedidos { get; set; }

        public Reportes(List<Classes.Pedido> infoPedidos)
        {
            InitializeComponent();
            pedidos = infoPedidos;

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Close();
            form1.Show();
    }

        private void Button7_Click(object sender, EventArgs e)
        {
            RecepcionPeriodos recepcion = new RecepcionPeriodos(pedidos);
            recepcion.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecepcionPedido recepcion = new RecepcionPedido(pedidos);
            recepcion.Show();
        }
    }
}
