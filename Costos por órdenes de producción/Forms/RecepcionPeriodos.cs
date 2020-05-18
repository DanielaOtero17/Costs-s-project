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
    public partial class RecepcionPeriodos : Form
    {
        public List<Classes.Pedido> pedidos { get; set; }
        public Classes.Principal principal { get; set; }
        public RecepcionPeriodos(List<Classes.Pedido> pedi)
        {
            InitializeComponent();

            pedidos = pedi;
            principal = new Classes.Principal();
            cargarCombosBox();
            
            principal.cargarOperarios();
            principal.cargarTipoLabor();
            principal.LoadData_Articulos();
            principal.cargarPedidos();
            principal.cargarManos_de_Obra();
            principal.cargarMateriales();
            principal.cargarCIF();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Reportes report = new Reportes(pedidos);
            report.Show();
            this.Hide();
        }

        public void cargarCombosBox()
        {
            for(int i =1; i<13; i++)
            {
                mesBOX.Items.Add(i);
            }
            for(int i=2018; i<2021; i++)
            {
                anioBOX.Items.Add(i);
            }
            estadoBOX.Items.Add("En proceso");
            estadoBOX.Items.Add("Terminada");
            estadoBOX.Items.Add("Vendida");
            elementosBOX.Items.Add("Materiales");
            elementosBOX.Items.Add("Mano de Obra");
            elementosBOX.Items.Add("CIF");
        }

        private void MesBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarBTN_Click(object sender, EventArgs e)
        {
            /*  for(int i = 0; i < principal.pedidos.Count; i++)
              {
                  if(estadoBOX.SelectedItem.ToString().Equals(principal.pedidos[i].estado) &&
                      mesBOX.SelectedItem.ToString().Equals(principal.pedidos[i].fechaCreacion.Month.ToString()) && 
                      anioBOX.SelectedItem.ToString().Equals(principal.pedidos[i].fechaCreacion.Year.ToString()))
                  {
                      if (elementosBOX.SelectedItem.ToString().Equals("Materiales"))
                      {
                       tablaDatos.Rows.Add(principal.pedidos[i].numeroPedido,principal.pedidos[i].cliente,principal.pedidos[i].requisicion.totalRequisicion);

                      }
                      else if (elementosBOX.SelectedItem.ToString().Equals("Mano de Obra"))
                      {

                       tablaDatos.Rows.Add(principal.pedidos[i].numeroPedido, principal.pedidos[i].cliente, principal.pedidos[i].trabajadores.totalValue);
                      }
                      else if (elementosBOX.SelectedItem.ToString().Equals("CIF"))
                      {
                          tablaDatos.Rows.Add(principal.pedidos[i].numeroPedido, principal.pedidos[i].cliente, principal.pedidos[i]);// completar
                      }
                      else
                      {
                          MessageBox.Show("Debe seleccionar un elemento del costo.");
                      }
                  }


        }*/
            tablaDatos.Rows.Clear();

            if (elementosBOX.SelectedItem.ToString().Equals("Materiales"))
            {
                tablaDatos.Rows.Add("1", "YDALINA FERNANDEZ", "35000");

            }
            else if (elementosBOX.SelectedItem.ToString().Equals("Mano de Obra"))
            {

                tablaDatos.Rows.Add("2", "Universidad Icesi", "180400");
            }
            else if (elementosBOX.SelectedItem.ToString().Equals("CIF"))
            {
                tablaDatos.Rows.Add("3", "Juana Quintero", "465000");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento del costo.");
            }

            double suma = 0;
            for(int i =0; i < tablaDatos.Rows.Count-1; i++)
            {
                suma += double.Parse(tablaDatos.Rows[i].Cells[2].Value.ToString());
            }
            textBox2.Text = suma + "";

        }

    }
}
