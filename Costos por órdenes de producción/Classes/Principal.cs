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
        public List<Pedido> pedidos { get; set; }
        public List<RequisicionMaterial> requisiciones {get; set;}
        public List<ManoDeObra> manos_de_obra { get; set; }

        public Principal()
        {
            articles = new List<Articulo>();
            codes = new List<int>();
            clients = new List<Cliente>();
            worktypes = new List<TipoLabor>();
            workers = new List<Operario>();
            pedidos = new List<Pedido>();
            requisiciones = new List<RequisicionMaterial>();
            manos_de_obra = new List<ManoDeObra>();
        }

        public void productRegister(String name, String desc, int code)
        {
            Articulo articulo = new Articulo(name, desc, code);

            articles.Add(articulo);
            addDataArticle(articulo);
        }

        /*
         * Busca una requisición con el número del pedido asociado
         * return: el método devuelve la requisición
        */
        public RequisicionMaterial SearchRequisicion(int numPedido)
        {
            Pedido aux = searchPedido(numPedido);
            int ubicacion = pedidos.BinarySearch(aux);

            return pedidos[ubicacion].requisicion;
        }

        public void registerClient(String name, String id, String typ)
        {
            Cliente client = new Cliente(name, id, typ);

            clients.Add(client);
            addDataClient(client);
        }
        public void registrarPedido(int codigo, int cantidad, Cliente cli, Articulo art, DateTime fecha )
        {
            Pedido pedido = new Pedido(codigo, cantidad, cli, art, fecha);

            pedidos.Add(pedido);
            addDataPedido(pedido);

        }

        public void registrarRequisicion(int numPedido,List<Material> materiales )
        {
            RequisicionMaterial requisicion = new RequisicionMaterial(numPedido,materiales);

            Pedido aux = searchPedido(numPedido);

            int ubicacion = pedidos.IndexOf(aux);
            
            pedidos[ubicacion].requisicion = requisicion;

            requisiciones.Add(requisicion);
            addDataRequisicion(requisicion);
        }
        public Cliente searchClient(String id)
        {
            for(int i = 0; i < clients.Count; i++)
            {
                if (id.Equals(clients[i].id))
                    return clients[i];
            }
            return null;
        }
        public Articulo searchArticle(String name)
        {
            for (int i = 0; i < articles.Count; i++)
            {
                if (name.Equals(articles[i].name))
                    return articles[i];
            }
            return null;
        }

        public Pedido searchPedido(int numPedido)
        {
            
            for (int i = 0; i < pedidos.Count; i++)
            {
                if (numPedido == pedidos[i].numeroPedido)
                {
                    return pedidos[i];
                }
                    
            }
            return null;
        }
        public void cargarPedidos()
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Pedidos.txt";

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

                           pedidos.Add(new Pedido(int.Parse(tipochar[0]), int.Parse(tipochar[1]),
                                searchClient(tipochar[2]), searchArticle(tipochar[3]),
                               new DateTime(int.Parse(tipochar[6]), int.Parse(tipochar[5]),
                               int.Parse(tipochar[4]))));

                        }
                    }
                }
            }
        }

        public void cargarTipoLabor()
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\tiposDeLabor.txt";

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

                            TipoLabor aux = buscarTipoLabor(tipochar[2]);

                            worktypes.Add(new TipoLabor(tipochar[0],double.Parse(tipochar[1])));
                        }
                    }
                }
            }
        }//FALTA COMPLETAR ESTE MÉTODO

        public TipoLabor buscarTipoLabor(String name)
        {
            for(int i = 0; i < worktypes.Count; i++){

                if (worktypes[i].name.Equals(name))
                    return worktypes[i];
            }
            return null;
        }

        public Operario buscarOperario(String name)
        {
            for (int i = 0; i < workers.Count; i++)
            {

                if (worktypes[i].name.Equals(name))
                    return workers[i];
            }
            return null;
        }

        public List<Operario> cargarOperarios()
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Operarios.txt";

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

                            TipoLabor aux = buscarTipoLabor(tipochar[2]);

                            workers.Add(new Operario(tipochar[0], tipochar[1], aux));

                        }
                    }
                }
            }
            return workers;
        }

        public void cargarManos_de_Obra() //FALTA COMPLETAR ESTE MÉTODO
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Mano de Obra.txt";

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

                            TipoLabor aux = buscarTipoLabor(tipochar[2]);


                            //FALTA COMPLETAR
                            manos_de_obra.Add(new ManoDeObra(int.Parse(tipochar[0]), null));

                        }
                    }
                }
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
                            articles.Add(new Classes.Articulo(tipochar[0], tipochar[1], int.Parse(tipochar[2])));
                        }
                    }
                }
            }
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

        public void addDataPedido(Pedido ped)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Pedidos.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(ped.numeroPedido + "/" + ped.cantidad + "/" + ped.cliente.name + "/" + ped.articulo.name + "/" + ped.fechaCreacion.ToShortDateString());
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(ped.numeroPedido + "/" + ped.cantidad + "/" + ped.cliente.name + "/" + ped.articulo.name + "/" + ped.fechaCreacion.ToShortDateString());
                }
            }
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

        public void addDataRequisicion(RequisicionMaterial requisicion)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Requisiciones_Materiales.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    String info = "";
                    for(int i=0; i < requisicion.materiales.Count; i++)
                    {
                        info += requisicion.materiales[i].descripcion + "-" +
                            requisicion.materiales[i].cantidad + "-" + requisicion.materiales[i].valorUnitario +
                            "-" + requisicion.materiales[i].valorTotal + "/" ;

                        Console.WriteLine(info);
                    }
                    sw.WriteLine(requisicion.numero_pedido + "/" + info);

               
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    String info = "";
                    for (int i = 0; i < requisicion.materiales.Count; i++)
                    {
                        info += requisicion.materiales[i].descripcion + "-" +
                            requisicion.materiales[i].cantidad + "-" + requisicion.materiales[i].valorUnitario +
                            "-" + requisicion.materiales[i].valorTotal + "/";
                    }
                    sw.WriteLine(requisicion.numero_pedido + "/" + info);
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
