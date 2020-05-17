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

        Classes.Pedido pedidoSeleccionado { get; set; }

        public RecepcionPedido(List<Classes.Pedido> listaPedidos)
        {
            principal = new Classes.Principal();
            InitializeComponent();
            pedidos = listaPedidos;
            principal.LoadData_Articulos();
            principal.cargarMateriales();
            principal.cargarTipoLabor();
            principal.cargarOperarios();
            principal.cargarManos_de_Obra();
            principal.cargarPedidos();
            principal.cargarCIF();
            cargarPedidos_comboBox();
            requisicion = new Forms.RequisicionMateriales(this);
            hoja = null;
            mano_De_Obra = new ManoObra(this);
            pedidoSeleccionado = null;
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

        public void cargarHojaCostosMOD()
        {
            Classes.Pedido ped = asignarTrabajadoresAPedido();
            try
            {

                for (int i = 0; i < ped.trabajadores.trabajadores.Count; i++)
                {
                    Classes.TipoLabor tipo = principal.buscarTipoLabor(ped.trabajadores.trabajadores[i].tipo);
                    hoja.tablaManoObra.Rows.Add(ped.trabajadores.trabajadores[i].name,
                       ped.trabajadores.trabajadores[i].horasTrabajadas, tipo.valuePerhour, ped.trabajadores.trabajadores[i].totalValue);
                }

            }
            catch
            {
                MessageBox.Show("No se ha podido cargar la hoda de mano de obra en costos.");
            }
        }
        private void HojaCostos_Btn_Click(object sender, EventArgs e)
        {


            hoja = new HojaCostos(pedidoSeleccionado, this);
            this.Visible = false;

            cargarHojaCostosRequisicion();
            cargarHojaCostosMOD();
            hoja.calcularTotalMD();
            hoja.calcularHorasTrabajadas();
            hoja.calcularTotalMO();

            Classes.CIF cif = darCifEscogido();
            hoja.cargarTablaCIF(cif.cif_presupuestado,cif.horas_presupuestadas);
            hoja.cargarTotalHojaCostos();

            hoja.Show();

        }

        public Classes.CIF darCifEscogido()
        {
            for(int i = 0; i < principal.cifs.Count; i++)
            {
                if(principal.cifs[i].numeroPedido == pedidoSeleccionado.numeroPedido)
                {
                    return principal.cifs[i];
                }
            }
            return null;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pedidoSeleccionado = darPedidoSeleccionado(int.Parse(comboBox1.SelectedItem.ToString()));

            textBox2.Text = pedidoSeleccionado.estado;

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


        private void Button2_Click(object sender, EventArgs e)
        {
            cargarDatosManoObra(asignarTrabajadoresAPedido());
            mano_De_Obra.Show();
            this.Hide();

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
            mano_De_Obra.tablaManoObra.Rows.Clear();

            ped = asignarTrabajadoresAPedido();

            mano_De_Obra.label6.Text = ped.numeroPedido + "";

            if (ped.trabajadores != null)
            {

                MessageBox.Show("Hay" + ped.trabajadores.trabajadores.Count + " trabajadores");

                for (int i = 0; i < ped.trabajadores.trabajadores.Count; i++)
                {
                    Classes.TipoLabor tipo = principal.buscarTipoLabor(ped.trabajadores.trabajadores[i].tipo);
                    mano_De_Obra.tablaManoObra.Rows.Add(ped.trabajadores.trabajadores[i].name,
                       ped.trabajadores.trabajadores[i].horasTrabajadas, tipo.valuePerhour, ped.trabajadores.trabajadores[i].totalValue);
                }

            }
            else
            {
                MessageBox.Show("No hay trabajadores");
            }
        }

        public void cargarDatosCIF()
        {

        }
        public void cargarDatosRequisicion(Classes.Pedido ped)
        {
            requisicion.tablaMateriales.Rows.Clear();
         //   asignarMaterialesAPedido();

            Classes.Articulo art = principal.searchArticle(ped.articulo);
            MessageBox.Show("El nombre del articulo es" + art.name);

            requisicion.label6.Text = ped.numeroPedido + "";
            requisicion.richTextBox1.Text = "CLIENTE: " + ped.cliente + "\n ARTICULO: " + art.name + ": " + art.description;

            ped = asignarMaterialesAPedido();

            if (ped.requisicion != null)
            {
                MessageBox.Show("Hay" + ped.requisicion.materiales.Count + " materiales");
                for (int i = 0; i < ped.requisicion.materiales.Count; i++)
                {

                    requisicion.tablaMateriales.Rows.Add(ped.requisicion.materiales[i].descripcion,
                     ped.requisicion.materiales[i].cantidad, ped.requisicion.materiales[i].valorUnitario,
                      ped.requisicion.materiales[i].valorTotal);
                }
            }
            else
            {
                MessageBox.Show("No hay materiales");
            }
        }

        public Classes.Pedido asignarTrabajadoresAPedido()
        {
           

            for (int i = 0; i < principal.manos_de_obra.Count; i++)
            {
                if (principal.manos_de_obra[i].numPedido == pedidoSeleccionado.numeroPedido)
                {
                    pedidoSeleccionado.trabajadores = principal.manos_de_obra[i];
                }
            }
            return pedidoSeleccionado;
        }

        public Classes.Pedido asignarMaterialesAPedido()
        {
             for (int i = 0; i < principal.requisiciones.Count; i++)
            {
                if (principal.requisiciones[i].numero_pedido == pedidoSeleccionado.numeroPedido)
                {
                    pedidoSeleccionado.requisicion = principal.requisiciones[i];
                }
            }
            return pedidoSeleccionado;
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

        private void Button3_Click(object sender, EventArgs e)
        {
            CostosIndirectos CIF = new CostosIndirectos(this);

            try
            {
                CIF.textBox2.Text = comboBox1.SelectedItem.ToString();
                Classes.Pedido ped = principal.searchPedido(int.Parse(comboBox1.SelectedItem.ToString()));

                Classes.CIF cifEsco = darCifEscogido();

                if (cifEsco != null)
                {
                    CIF.textBox1.Text = cifEsco.cif_presupuestado.ToString();
                    CIF.textBox3.Text = cifEsco.horas_presupuestadas.ToString();
                }

                this.Hide();
                CIF.Show();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un número de pedido", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            
            
        }
    }
}
