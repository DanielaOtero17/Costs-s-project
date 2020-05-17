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
        public RecepcionPedido recepcion;
        public Classes.Principal principal;

        public CostosIndirectos(RecepcionPedido recep)
        {
            InitializeComponent();
            recepcion = recep;
            principal = new Classes.Principal();
            principal.cargarPedidos();
                            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            recepcion.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //try
          //  {
               Classes.Pedido ped = principal.searchPedido(int.Parse(textBox2.Text));

            MessageBox.Show(ped.CIF_presupuestado + "presupuestado");
                ped.CIF_presupuestado = double.Parse(textBox1.Text);
                ped.Horas_presupuestadas = int.Parse(textBox3.Text);

            principal.registrarCIF(ped.numeroPedido, ped.CIF_presupuestado, ped.Horas_presupuestadas);
            MessageBox.Show(ped.CIF_presupuestado + "Se han registrado correctamente los presupuestos. ");
            /* }
            catch
             {
                 MessageBox.Show("Debe ingresar valores válidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }*/
        }
    }
}
