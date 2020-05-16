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
        
        public List<Classes.Pedido> pedidos { get; set; }
        public RecepcionPedido( List<Classes.Pedido> listaPedidos)
        {
            InitializeComponent();
            pedidos = listaPedidos;
        }

        private void RecepcionPedido_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reporte = new Reportes(pedidos);
            reporte.Show();
        }

        private void HojaCostos_Btn_Click(object sender, EventArgs e)
        {
            
            HojaCostos hoja = new HojaCostos(darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString())));
            this.Close();
            hoja.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Classes.Pedido darPedidoSeleccionado(int numPedido)
        {
            for (int i = 0; i < pedidos.Count; i++)
            {
                if (numPedido == pedidos[i].numeroPedido)
                {
                    return pedidos[i];
                }

            }
            return null;
        }
    }
}
