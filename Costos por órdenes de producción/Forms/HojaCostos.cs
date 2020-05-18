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

        public double totalHorasTrabajadas { get; set; }

        public Classes.Principal principal { get; set; }

        public HojaCostos(Classes.Pedido elPedido,RecepcionPedido ventanaAntes)
        {
            InitializeComponent();
            principal = new Classes.Principal();
            pedido = elPedido;
            textBox2.Text = pedido.numeroPedido + "";
            
            recepcion = ventanaAntes;
            totalHorasTrabajadas = 0;
            
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
            double cif = double.Parse(totalCIF.Text);
                
            double total = materiales + manoDeObra + cif;
            costoTotal.Text = total + "";
            principal.cargarPedidos();
            principal.asignarCIFTotalAPedido(total, int.Parse(textBox2.Text));
        }

        public double calcularHorasTrabajadas()
        {
           
           for(int i=0;i< tablaManoObra.Rows.Count-1; i++)
            {
                totalHorasTrabajadas += double.Parse(tablaManoObra.Rows[i].Cells[1].Value.ToString());
            }
            tablaCIF.Rows[0].Cells[3].Value = totalHorasTrabajadas;
            return totalHorasTrabajadas;
        }

        public double darTasa(double cifp, int horasp)
        {
            if (horasp != 0)
            {
                double tasa = cifp / horasp;

                return tasa;
            }            
            return 0;

        }

        public void cargarTablaCIF(double presupuesto, int horasPresupuestadas)
        {

            double cifTASA = darTasa(presupuesto, horasPresupuestadas);

            tablaCIF.Rows[0].Cells[0].Value = presupuesto;
            tablaCIF.Rows[0].Cells[1].Value = horasPresupuestadas;
            tablaCIF.Rows[0].Cells[2].Value = cifTASA;
            tablaCIF.Rows[0].Cells[3].Value = totalHorasTrabajadas;

            double TOTAL = cifTASA * totalHorasTrabajadas;
            totalCIF.Text = TOTAL+ "";

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
