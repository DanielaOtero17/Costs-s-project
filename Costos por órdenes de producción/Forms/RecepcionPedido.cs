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
        HojaCostos hoja { get; set; }

        ManoObra mano_De_Obra { get; set; }

        public RecepcionPedido(List<Classes.Pedido> listaPedidos)
        {
            principal = new Classes.Principal();
            InitializeComponent();
            pedidos = listaPedidos;
            cargarPedidos_comboBox();
            principal.LoadData_Articulos();
            principal.cargarMateriales();
            principal.cargarTipoLabor();
            requisicion = new Forms.RequisicionMateriales(this);
            hoja = null;
            mano_De_Obra = new ManoObra(this);
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
            

            hoja = new HojaCostos(darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString())),this);
           this.Visible = false;

            cargarHojaCostosRequisicion();
            hoja.calcularTotalMD();
            hoja.calcularHorasTrabajadas();
            hoja.cargarTotalHojaCostos();

            hoja.Show();
        
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.Pedido ped = darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString()));
            textBox2.Text = ped.estado;
           
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

             try
             {
                cargarDatosRequisicion(asignarMaterialesAPedido());
                requisicion.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
        }

        public void cargarHojaCostosRequisicion()
        {
            Classes.Pedido ped = asignarMaterialesAPedido();
            try
            {
                for (int i = 0; i < ped.requisicion.materiales.Count; i++)
                {
                    hoja.tablaMateriales.Rows.Add(ped.requisicion.materiales[i].descripcion,
                        ped.requisicion.materiales[i].cantidad, ped.requisicion.materiales[i].valorUnitario,
                        ped.requisicion.materiales[i].valorTotal);
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido cargar la hoda de materiales en costos.");
            }

        }

        public void cargarDatosManoObra(Classes.Pedido ped)
        {

        }
        public void cargarDatosRequisicion(Classes.Pedido ped)
        {
             asignarTrabajadoresAPedido();

            if (ped.trabajadores != null)
            {

                MessageBox.Show("Hay" + ped.trabajadores.trabajadores.Count + " trabajadores");
                for (int i = 0; i < ped.trabajadores.trabajadores.Count; i++)
                {
                    mano_De_Obra.tablaManoObra.Rows.Add(ped.trabajadores.trabajadores[i].name,
                       ped.trabajadores.trabajadores[i].horasTrabajadas, ped.trabajadores.trabajadores[i].tipo.valuePerhour,
                        ped.trabajadores.totalValue); 
                }

            }
            else
            {
                MessageBox.Show("No hay trabajadores");
            }
        }

        public Classes.Pedido asignarTrabajadoresAPedido()
        {
            Classes.Pedido ped = darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString()));

            for (int i = 0; i < principal.manos_de_obra.Count; i++)
            {
                if (principal.manos_de_obra[i].numPedido == ped.numeroPedido)
                {
                    ped.trabajadores = principal.manos_de_obra[i];                       ;
                }
            }
            return ped;
        }

        public Classes.Pedido asignarMaterialesAPedido()
        {
            Classes.Pedido ped = darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString()));
        
            for (int i = 0; i < principal.requisiciones.Count; i++)
            {
                if (principal.requisiciones[i].numero_pedido==ped.numeroPedido )
                {
                    ped.requisicion = principal.requisiciones[i];
                }
            }
            return ped;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Classes.Pedido ped = darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString()));
            
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Si cambia el estado de un pedido, no podrá volver a modificarlo. " +
                "¿Está seguro de esta acción?", "Confirmación", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                textBox2.Text = ped.cambiarEstado();
            }
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cargarDatosManoObra(asignarMaterialesAPedido());
       
            this.Hide();
        }
    }


}
