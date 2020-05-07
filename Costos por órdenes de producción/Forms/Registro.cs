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
    public partial class Registro : Form
    {
        private Classes.Principal principal { get; set; }
        
        public Registro()
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeTextArticle(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Random code = new Random();

            int value = code.Next(1, 999999);

            if (principal.codes != null)
            {
                while (principal.codes.Contains(value) == true)
                {
                    value = code.Next(1, 999999);
                }
            }
            this.referenciaText.Text = value + "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("") || DescripcionArticulo.Text.Equals("") || referenciaText.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else {
                principal.productRegister(textBox1.Text, DescripcionArticulo.Text, int.Parse(referenciaText.Text));
                MessageBox.Show("Se ha registrado correctamente el árticulo " + textBox1.Text);
                clean();
            }
        }

        public void clean()
        {
            textBox1.Text = "";
            DescripcionArticulo.Text = "";
            referenciaText.Text = "";
        }
    }
}
