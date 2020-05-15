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
    public partial class RequisicionMateriales : Form
    {
        int cantidad = 0;
        decimal precio_Unitario = 0;
        decimal precio_Total = 0;
        List<Classes.Material> materiales { get; set; }
        Classes.Principal principal { get; set; }

        int verif = 0;
       

        public RequisicionMateriales()
        {
            InitializeComponent();
            principal = new Classes.Principal();
            materiales = new List<Classes.Material>();

            principal.cargarPedidos();
            principal.LoadData_Articulos();

        }

        public List<Classes.Material> darMateriales()
        {

            List<Classes.Material> listaMaterial = new List<Classes.Material>();

            return listaMaterial;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TablaMateriales_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void TablaMateriales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaMateriales.Columns[e.ColumnIndex].Name == "ColumnaValorUnitario")
            {
                try
                {
                    cantidad = int.Parse(tablaMateriales.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("¡Debe ingresar una cantidad!");
                }
                try
                {
                    precio_Unitario = decimal.Parse(tablaMateriales.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("¡Debe ingresar el precio unitario!");
                }

                precio_Total = cantidad * precio_Unitario;
                tablaMateriales.Rows[e.RowIndex].Cells[3].Value = precio_Total;
            }
           
        

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void calcularTotal()
        {
            decimal suma = 0;

            for (int i = 0; i < tablaMateriales.RowCount; i++)
            {
                if (tablaMateriales.Rows[i].Cells[3].Value != null)
                {
                    suma += decimal.Parse(tablaMateriales.Rows[i].Cells[3].Value.ToString());

                    Classes.Material material = new Classes.Material(tablaMateriales.Rows[i].Cells[0].Value.ToString(),
                        int.Parse(tablaMateriales.Rows[i].Cells[1].Value.ToString()),
                        double.Parse(tablaMateriales.Rows[i].Cells[2].Value.ToString()), 
                        double.Parse(tablaMateriales.Rows[i].Cells[3].Value.ToString()));

                    materiales.Add(material);
               
                }
            }
            textBox2.Text = suma + "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            verif = 1;

            principal.registrarRequisicion(int.Parse(label6.Text),materiales);
            MessageBox.Show("La requisición se ha registrado con éxito.");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (verif == 0)
            {
                MessageBox.Show("Primero debe guardar los datos de la requisición.");
            }
            else
            {
                this.Hide();
                Form1 principal = new Form1();
                principal.Show();
            }
        }
    }
}
