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

        public RecepcionPedido recepcion { get; set; }

        public HojaCostos(Classes.Pedido elPedido,RecepcionPedido ventanaAntes)
        {
            InitializeComponent();
            pedido = elPedido;
            textBox2.Text = pedido.numeroPedido + "";
            
            recepcion = ventanaAntes;
            
        }

        public void calcularTotalMD()
        {
            double total = 0;
            for(int i=0; i<tablaMateriales.Rows.Count -1; i++)
            {
                total += double.Parse(tablaMateriales.Rows[i].Cells[3].Value.ToString());
            }
          
           totalMD.Text = total+"";

        }

        public void calcularTotalMO()
        {
            double total = 0;
            for (int i = 0; i < tablaManoObra.Rows.Count - 1; i++)
            {
                total += double.Parse(tablaManoObra.Rows[i].Cells[3].Value.ToString());
            }
            
            totalMO.Text = total + "";
        }
        
        public void cargarTotalHojaCostos()
        {
            
            double materiales = double.Parse(totalMD.Text);
            double manoDeObra = double.Parse(totalMO.Text);

           double cif = darTasa() * calcularHorasTrabajadas();
            double total = materiales + manoDeObra + cif;
            costoTotal.Text = total + "";
        }

        public double calcularHorasTrabajadas()
        {
            double totalHoras = 0;
           for(int i=0;i< tablaManoObra.Rows.Count-1; i++)
            {
                totalHoras += double.Parse(tablaManoObra.Rows[i].Cells[1].Value.ToString());
            }
            tablaCIF.Rows[0].Cells[3].Value = totalHoras;
            return totalHoras;
        }

        public double darTasa()
        {
            double cifP = pedido.CIF_presupuestado;
            double horasP = pedido.Horas_presupuestadas;
            double tasa = 0;
            if (cifP > 0 && horasP > 0)
            {
                tasa = cifP/horasP;
            }
            return tasa;
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

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TablaMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            recepcion.Show();
        }

        private void TotalMD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
