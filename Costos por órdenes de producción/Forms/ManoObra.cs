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
    public partial class ManoObra : Form
    {
        private Classes.Principal principal { get; set; }
        public RecepcionPedido recepcion { get; set; }
        public ManoObra(RecepcionPedido recep)
        {
            InitializeComponent();
            principal = new Classes.Principal();
            recepcion = recep;
            principal.cargarPedidos();
            principal.cargarOperarios();
            principal.cargarTipoLabor();
            cargarComboBox_Operarios();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double sum = 0;

            for(int i = 0; i < tablaManoObra.Rows.Count; i++)
            {
                sum += double.Parse(tablaManoObra.Rows[i].Cells[3].Value.ToString());
            }

            textBox2.Text = sum+"";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=1;i<99999;i++)
            comboBox2.Items.Add(i);

           
        }

        public void cargarComboBox_Operarios()
        {
           for(int i = 0; i < principal.workers.Count; i++)
            {
                comboBox1.Items.Add(principal.workers[i].name);
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String nombreOperario = comboBox1.SelectedItem.ToString();
            int cantidadHoras = int.Parse(comboBox2.SelectedItem.ToString());

            Classes.Operario operarioAux = principal.buscarOperario(nombreOperario);
           
            double pUnitario = operarioAux.tipo.valuePerhour;          

            int pos = tablaManoObra.Rows.Count;

            tablaManoObra.Rows[pos - 1].Cells[0].Value = nombreOperario;
            tablaManoObra.Rows[pos - 1].Cells[1].Value = cantidadHoras;
            tablaManoObra.Rows[pos - 1].Cells[2].Value = pUnitario;

            double pTotal = pUnitario * cantidadHoras;

            tablaManoObra.Rows[pos - 1].Cells[4].Value = pTotal;
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            recepcion.Show();
        }
    }
}
