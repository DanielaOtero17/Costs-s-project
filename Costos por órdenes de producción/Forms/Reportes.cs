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
    public partial class Reportes : Form
    {
        
        public Reportes()
        {
            InitializeComponent();
           
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Close();
            form1.Show();
    }

        private void Button7_Click(object sender, EventArgs e)
        {
            int numPedido = ;
        }
    }
}
