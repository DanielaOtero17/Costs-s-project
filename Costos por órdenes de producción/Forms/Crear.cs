using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Costos_por_órdenes_de_producción
{
    public partial class Crear : Form
    {
        public Form1 ventanaPrincipal;
        private Classes.Principal principal;
        public Crear()
        {
            InitializeComponent();
            ventanaPrincipal = new Form1();
            principal = new Classes.Principal();
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            actualizarComboBox_Clientes();
            actualizarComboBox_Articulos();

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 form = new Form1();
            form.Show();
           
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime fecha = fechaPedido.Value;
            Classes.Cliente cli = principal.searchClient(darIdClienteEscogido());
            Classes.Articulo art = principal.searchArticle(darIdArticuloEscogido());

            principal.registrarPedido(int.Parse(label6.Text), int.Parse(textBox2.Text), cli, art, fecha);
            MessageBox.Show(null," Continuemos con el formulario de Requisición.", "Registro satisfactorio");
            this.Hide();
            GestionOrden gestionOrden = new GestionOrden();
            gestionOrden.Show();
        }

        private String darIdClienteEscogido()
        {
            String nombreID = comboBox1.SelectedItem.ToString();
            String[] datosCliente = nombreID.Split('-');
            return datosCliente[1];
        }
        public String darIdArticuloEscogido()
        {
            return comboBox2.SelectedItem.ToString();
        }
        public void LoadData_Clientes()
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\clientes.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Boolean verif = false;
                    while (verif == false)
                    {
                        String tipocomp = sr.ReadLine();

                        if (tipocomp == null)
                        {
                            verif = true;
                        }
                        else
                        {
                            String[] tipochar = tipocomp.Split('/');
                            double val = double.Parse(tipochar[1]);
                            principal.clients.Add(new Classes.Cliente(tipochar[0], tipochar[1],tipochar[2]));

                        }
                    }
                }
            }
        }

        public void actualizarComboBox_Clientes()
        {
            
            //Llamado al método que carga los datos desde el archivo al comboBox
            LoadData_Clientes();


            //añade los items al comboBox
            for (int i = 0; i < principal.clients.Count; i++)
            {
                comboBox1.Items.Add(principal.clients[i].name+"-" + principal.clients[i].id);
            }
        }

        public void actualizarComboBox_Articulos()
        {

            //Llamado al método que carga los datos desde el archivo al comboBox
            LoadData_Articulos();


            //añade los items al comboBox
            for (int i = 0; i < principal.articles.Count; i++)
            {
                comboBox2.Items.Add(principal.articles[i].name);
            }
        }

        public void LoadData_Articulos()
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\articulos.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Boolean verif = false;
                    while (verif == false)
                    {

                        String tipocomp = sr.ReadLine();

                        if (tipocomp == null)
                        {
                            verif = true;
                        }
                        else
                        {
                            String[] tipochar = tipocomp.Split('/');
                           // MessageBox.Show(tipocomp);
                            principal.articles.Add(new Classes.Articulo(tipochar[0], tipochar[1], int.Parse(tipochar[2])));
                        }
                    }
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
