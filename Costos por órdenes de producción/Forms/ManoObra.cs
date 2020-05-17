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
        public List<Classes.Operario> manoDeObras { get; set; }

        public double totalMO { get; set; }

        public ManoObra(RecepcionPedido recep)
        {
            InitializeComponent();
            principal = new Classes.Principal();
            recepcion = recep;
            principal.cargarPedidos();
            principal.cargarOperarios();
            principal.cargarTipoLabor();
            cargarComboBox_Operarios();
            totalMO = 0;
            manoDeObras = new List<Classes.Operario>();
            
        }

       
        private void Button2_Click(object sender, EventArgs e)
        {
            double sum = 0;

            for(int i = 0; i < tablaManoObra.Rows.Count-1; i++)
            {
                sum += double.Parse(tablaManoObra.Rows[i].Cells[3].Value.ToString());


            }

            textBox2.Text = sum + "";

            calcularTotal();

        }

        public double calcularTotal()
        {
            double suma = 0;

            for (int i = 0; i < tablaManoObra.Rows.Count - 1; i++)
            {
                
                    suma += double.Parse(tablaManoObra.Rows[i].Cells[3].Value.ToString());
                Classes.Operario opAux = principal.buscarOperario(tablaManoObra.Rows[i].Cells[0].Value.ToString());

                Classes.Operario operario = new Classes.Operario(tablaManoObra.Rows[i].Cells[0].Value.ToString(),
                    opAux.id, opAux.tipo);

                       operario.horasTrabajadas = int.Parse(tablaManoObra.Rows[i].Cells[1].Value.ToString());
                       operario.valorUnitario = double.Parse(tablaManoObra.Rows[i].Cells[2].Value.ToString());
                       operario.totalValue = double.Parse(tablaManoObra.Rows[i].Cells[3].Value.ToString());

                    manoDeObras.Add(operario);

            }
            textBox2.Text = suma + "";
            totalMO = suma;
            return suma;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            principal.registrarManoObra(int.Parse(label6.Text), manoDeObras,totalMO);
            MessageBox.Show("La requisición se ha registrado con éxito.");
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           
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
            int cantidadHoras = int.Parse(textBox1.Text);

            Classes.Operario operarioAux = principal.buscarOperario(nombreOperario);
            Classes.TipoLabor tipoaux = darTipoLabor(operarioAux.tipo);
           
            double pUnitario = 0;
            if (tipoaux != null)
            {
                
                 pUnitario = tipoaux.valuePerhour;
            }
            else
            {
                MessageBox.Show("El tipo de labor es nulo.");
            }

            int pos = tablaManoObra.Rows.Count;

            double pTotal = pUnitario * cantidadHoras;

            tablaManoObra.Rows.Add(nombreOperario, cantidadHoras, pUnitario, pTotal);
          
        }

        public Classes.TipoLabor darTipoLabor(String nombreTipo)
        {
            for (int i = 0; i < principal.worktypes.Count; i++)
            {
                MessageBox.Show("nombre de tipo principal: |" + principal.worktypes[i].name+ "|"  + "\nnombre tipo parametro: |" + nombreTipo + "|");

                if (principal.worktypes[i].name.Equals(nombreTipo))
                {
                    MessageBox.Show("los tipos nombres coinciden");
                    return principal.worktypes[i];
                }

            }
            return null;
        }
        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            recepcion.Show();
        }

        private void ManoObra_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
