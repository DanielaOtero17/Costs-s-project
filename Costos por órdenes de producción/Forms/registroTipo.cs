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
    public partial class registroTipo : Form
    {
        private Classes.Principal principal { get; set; }
        private Form1 ventanaPrincipal { get; set; }


        public registroTipo()
        {
            principal = new Classes.Principal();
            ventanaPrincipal = new Form1();
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
                if (nombre.Text.Equals("")) { 
                    MessageBox.Show("Debe colocar un nombre.");
                }
                else if(double.Parse(textBox2.Text) < 0)
                {
                    MessageBox.Show("El formato de número no es válido.");
                }
                else
                {
                    principal.registrarTipo(nombre.Text, double.Parse(textBox2.Text));
                    MessageBox.Show("Se ha registrado correctamente el tipo " + nombre.Text);
                    clean();                  
                    this.Hide();
                ventanaPrincipal.regis.actualizarComboBox();
                ventanaPrincipal.regis.Refresh();
                ventanaPrincipal.regis.Show();

                //  regisOp.Show();
            }  
            
        }

        

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void clean()
        {
            nombre.Clear();
            textBox2.Clear();          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaPrincipal.regis.Show();
        }
    }
}
