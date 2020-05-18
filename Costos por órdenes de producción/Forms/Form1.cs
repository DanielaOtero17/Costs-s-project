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
    public partial class Form1 : Form
    {
        public Forms.RegistroOperario regis;
        private Classes.Principal principal;
  

        public Form1()
        {
            InitializeComponent();
            regis = new Forms.RegistroOperario();
            principal = new Classes.Principal();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

      

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Search searc = new Search();
            searc.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Crear crea = new Crear();
           
            crea.Show();
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registro regis = new Registro();
            regis.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Customer_register custom = new Customer_register();
           custom.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            regis.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Forms.Reportes reporte = new Forms.Reportes(principal.cargarPedidos()) ;
            reporte.Show();
        }
    }
}
