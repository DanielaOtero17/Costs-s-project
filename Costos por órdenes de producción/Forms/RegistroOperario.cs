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


namespace Costos_por_órdenes_de_producción.Forms
{
    public partial class RegistroOperario : Form
    {

        private registroTipo regis { get; set; }
        private Classes.Principal principal;

        public RegistroOperario()
        {
            principal = new Classes.Principal();
            InitializeComponent();
        }

        private void RegistroOperario_Load(object sender, EventArgs e)
        {
            actualizarComboBox();
        }

        public void actualizarComboBox()
        {
            // primero limpio la lista y el comboBox, para evitar bugs.            
            principal.worktypes.Clear();
            listaTipos.Items.Clear();            
            //Llamado al método que carga los datos desde el archivo al comboBox
            LoadData_Types();
           

            //añade los items al comboBox
            for (int i = 0; i < principal.worktypes.Count; i++)
            {
                listaTipos.Items.Add(principal.worktypes[i].name + 
                    " - " + principal.worktypes[i].valuePerhour);
            }   
        }

        public void LoadData_Types()
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\tiposDeLabor.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Boolean verif = false;
                    while(verif == false) {
                        
                        String tipocomp = sr.ReadLine();
                        
                        if (tipocomp == null)
                        {
                            verif = true;
                        }
                        else
                        {
                            String[] tipochar = tipocomp.Split('/');
                            MessageBox.Show(tipocomp);
                           double val = double.Parse(tipochar[1]);
                           principal.worktypes.Add(new Classes.TipoLabor(tipochar[0], val));                             
                        }
                    }                   
                }
            }
        }

        public Boolean tipoExiste(String nombreTipo, double valor)
        {
            return principal.worktypes.Contains(new Classes.TipoLabor(nombreTipo, valor));

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            this.Hide();
            principal.Show();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe colocar un nombre.");
            }
            else if (double.Parse(textBox2.Text) < 0)
            {
                MessageBox.Show("El formato de número no es válido.");
            }
            else if (listaTipos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de operario.");
            }
            else
            {
                principal.registrarOperario(textBox1.Text,textBox2.Text,darLaborEscogida());
                MessageBox.Show("Se ha registrado correctamente el operario " + textBox1.Text);
                clean();   
            }
        }
        public void clean()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private Classes.TipoLabor darLaborEscogida()
        {
            String nombre = listaTipos.SelectedItem.ToString();
            String[] name = nombre.Split('-');
            Classes.TipoLabor aux = new Classes.TipoLabor(name[0],double.Parse(name[1]));
            return aux;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            registroTipo tipo = new registroTipo();
            this.Hide();
            tipo.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

    }
}
