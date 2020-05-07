using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costos_por_órdenes_de_producción
{
    public partial class Customer_register : Form
    {
        private Classes.Principal principal{get; set;}
        public Customer_register()
        {
            InitializeComponent();
            principal = new Classes.Principal();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String tipo = "";

            if(radioButton2.Checked && radioButton1.Checked)
            {
                MessageBox.Show("Sólo puede escoger un tipo de persona.");
            }

            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || (!radioButton2.Checked && !radioButton1.Checked))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    tipo = radioButton1.Text;
                }
                else
                {
                    tipo = radioButton2.Text;
                }
                principal.registerClient(textBox1.Text, textBox2.Text, tipo);
                MessageBox.Show("Se ha registrado correctamente el cliente " + textBox1.Text);
                clean();
            }
        }

        public void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
