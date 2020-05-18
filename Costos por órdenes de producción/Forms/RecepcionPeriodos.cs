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
        public RecepcionPeriodos(List<Classes.Pedido> pedi)
        {
            InitializeComponent();

            pedidos = pedi;
            cargarCombosBox();

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
    }
}
