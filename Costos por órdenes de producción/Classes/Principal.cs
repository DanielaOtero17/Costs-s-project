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
        public List<Operario> workers { get; set; }
        public List<TipoLabor> worktypes { get; set; }
        public Principal()
        {
            articles = new List<Articulo>();
            codes = new List<int>();
            clients = new List<Cliente>();
            worktypes = new List<TipoLabor>();
            workers = new List<Operario>();
        }

        public void productRegister(String name, String desc, int code)
        {
            Articulo articulo = new Articulo(name, desc, code);

            articles.Add(articulo);
            addDataArticle(articulo);

        }
        public void registerClient(String name, String id, String typ)
        {
            Cliente client = new Cliente(name, id, typ);

            clients.Add(client);
            addDataClient(client);
        }

        public void registrarTipo(String name, double value)
        {
            TipoLabor tipo = new TipoLabor(name,value);
           
            worktypes.Add(tipo);
            addDataTypes(tipo);
        }

        public void registrarOperario(String name, String id, TipoLabor tipo)
        {
            Operario worker = new Operario(name,id,tipo);
            workers.Add(worker);
            addDataWorkers(worker);
        }

        public void addDataClient(Cliente cli)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\clientes.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(cli.name + "/" + cli.id + "/" + cli.tipo);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine( cli.name + "/" + cli.id + "/" + cli.tipo);
                }
            }
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

        public void addDataTypes(TipoLabor tipo)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\tiposDeLabor.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(tipo.name + "/" + tipo.valuePerhour );
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(tipo.name + "/" + tipo.valuePerhour);
                }
            }
        }

        public void addDataWorkers(Operario operario)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Operarios.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(operario.name + "/" + operario.id + "/" + operario.tipo.name);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(operario.name + "/" + operario.id + "/" + operario.tipo.name);
                }
            }
        }
    }
}
