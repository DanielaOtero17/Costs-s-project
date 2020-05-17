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
        public Classes.Principal principal { get; set; }

        Forms.RequisicionMateriales requisicion { get; set; }
        public RecepcionPedido(List<Classes.Pedido> listaPedidos)
        {
            principal = new Classes.Principal();
            InitializeComponent();
            pedidos = listaPedidos;
            cargarPedidos_comboBox();
            principal.LoadData_Articulos();
            principal.cargarMateriales();
            requisicion = new Forms.RequisicionMateriales(this);
        }

        private void RecepcionPedido_Load(object sender, EventArgs e)
        {

        }

        public void cargarPedidos_comboBox()
        {
            for (int i = 0; i < pedidos.Count; i++)
            {
                comboBox1.Items.Add(pedidos[i].numeroPedido + "");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reporte = new Reportes(pedidos);
            reporte.Show();
        }

        private void HojaCostos_Btn_Click(object sender, EventArgs e)
        {
            try{ 

            HojaCostos hoja = new HojaCostos(darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString())),this);
                this.Visible = false;;
            hoja.Show();
        }
           catch
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
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

       
        private void Button1_Click(object sender, EventArgs e)
        {
      
          // try
          //  {
                Classes.Pedido ped = darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString()));
                cargarDatosRequisicion(ped);
                requisicion.Show();
                this.Hide();
            
           /* }
            catch
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }*/
        }

        public void cargarDatosRequisicion(Classes.Pedido ped)
        {
            requisicion.label6.Text = ped.numeroPedido + "";
            Classes.Articulo art = principal.searchArticle(ped.articulo);
            requisicion.richTextBox1.Text = art.name + ": " + art.description + "";

            if (ped.requisicion != null)
            {
                
                for(int i= 0; i < requisicion.darMateriales().Count; i++)
                {
                    requisicion.tablaMateriales.Rows.Add(requisicion.darMateriales()[i].descripcion, 
                        requisicion.darMateriales()[i].cantidad, requisicion.darMateriales()[i].valorUnitario,
                        requisicion.darMateriales()[i].valorTotal);
                }

            }
        }


    }
}
