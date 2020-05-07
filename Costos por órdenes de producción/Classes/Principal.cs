using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Costos_por_órdenes_de_producción.Classes
{
    class Principal
    {
        public List<Articulo> articles { get; set; }
        public List<int> codes { get; set; }
        public List<Cliente> clients { get; set; }

        public Principal()
        {
            articles = new List<Articulo>();
            codes = new List<int>();
            clients = new List<Cliente>();
        }

        public void productRegister(String name, String desc, int code)
        {
            Articulo articulo = new Articulo(name, desc, code);

            articles.Add(articulo);
            addDataArticle(articulo);

        }

        public void addDataArticle(Articulo art)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\articulos.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(art.name + "/" + art.description + "/" + art.number);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(art.name + "/" + art.description + "/" + art.number);
                }

            }
        }
    }
}
