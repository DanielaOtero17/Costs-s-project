using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Costos_por_órdenes_de_producción.Classes
{
    public class Principal
    {
        

        public List<Articulo> articles { get; set; }
        public List<int> codes { get; set; }
        public List<Cliente> clients { get; set; }
        public List<Operario> workers { get; set; }
        public List<TipoLabor> worktypes { get; set; }
        public List<Pedido> pedidos { get; set; }
        public List<RequisicionMaterial> requisiciones { get; set; }
        public List<ManoDeObra> manos_de_obra { get; set; }

        public List<CIF> cifs { get; set; }
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
            cifs = new List<CIF>();
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
        public void registrarPedido(int codigo, int cantidad, String cli, String art, DateTime fecha)
        {
            Pedido pedido = new Pedido(codigo, cantidad, cli, art, fecha);

            pedidos.Add(pedido);
            addDataPedido(pedido);

        }

        public void asignarCIFTotalAPedido(double costo, int numPedido)
        {
            Pedido aux = searchPedido(numPedido);
            int ubicacion = pedidos.IndexOf(aux);

            pedidos[ubicacion].totalCif = costo;

        }
        public void registrarRequisicion(int numPedido, List<Material> materiales,double totalRequi)
        {
            RequisicionMaterial requisicion = new RequisicionMaterial(numPedido, materiales);
            requisicion.totalRequisicion = totalRequi;

            Pedido aux = searchPedido(numPedido);

            int ubicacion = pedidos.IndexOf(aux);

            pedidos[ubicacion].requisicion = requisicion;

            requisiciones.Add(requisicion);
            addDataRequisicion(requisicion);
        }
        public Cliente searchClient(String id)
        {
            for (int i = 0; i < clients.Count; i++)
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
        public List<Pedido> cargarPedidos()
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
                                 tipochar[2], tipochar[3],
                                new DateTime(int.Parse(tipochar[6]), int.Parse(tipochar[5]),
                                int.Parse(tipochar[4]))));

                        }
                    }
                }
            }
            return pedidos;
        }
        public void cargarMateriales() 
            {
                string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Requisiciones_Materiales.txt";

           
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        Boolean verif = false;
                        while (verif == false)
                        {
                            String line1 = sr.ReadLine();
                            String line2 = sr.ReadLine();


                            if (line1 == null)
                            {
                                verif = true;
                            }
                            else
                            {
                                String[] id_total = line1.Split('/');
                                String[] materiales = line2.Split('/');
                                List<Material> materials = new List<Material>();

                            
                                for (int i = 0; i < materiales.Length-1; i++)
                                {
                                    String[] material_aux = materiales[i].Split('-');

                                Material mat = new Material(material_aux[0], int.Parse(material_aux[1]), double.Parse(material_aux[2]),
                                        double.Parse(material_aux[3]));
                                    materials.Add(mat);
                                
                            }
                            RequisicionMaterial requi = new RequisicionMaterial(int.Parse(id_total[0]), materials);
                            requi.totalRequisicion = double.Parse(id_total[1]);
                            requisiciones.Add(requi);
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

                          //  TipoLabor aux = buscarTipoLabor(tipochar[1]);

                            worktypes.Add(new TipoLabor(tipochar[0],double.Parse(tipochar[1])));
                            
                        }
                    }
                }
            }
        }

        public TipoLabor buscarTipoLabor(String name)
        {
            for(int i = 0; i < worktypes.Count; i++){

                if (worktypes[i].name.Equals(name))
                {
                    return worktypes[i];
                }
                  
            }
            return null;
        }

        public Operario buscarOperario(String name)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].name.Equals(name))
                {

                    return workers[i];
                }
            }
            return null;
        }
        
        public void registrarCIF(int numPed, double cifpre, int horasp)
        {
            CIF nuevo = new CIF(numPed, cifpre,horasp);
            cifs.Add(nuevo);

           int index =  pedidos.IndexOf(searchPedido(numPed));

            pedidos[index].CIF_presupuestado = cifpre;
            pedidos[index].Horas_presupuestadas = horasp;

            addDataCIF(nuevo);
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

                            workers.Add(new Operario(tipochar[0], tipochar[1], tipochar[2]));

                        }
                    }
                }
            }
            return workers;
        }

        public void cargarCIF()
        {
            
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\CIF.txt";

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

                            CIF cifAUX = new CIF(int.Parse(tipochar[0]),double.Parse(tipochar[1]), int.Parse(tipochar[2]));
                            cifs.Add(cifAUX);
                            int index = pedidos.IndexOf(searchPedido(cifAUX.numeroPedido));
                            
                            pedidos[index].CIF_presupuestado = cifAUX.cif_presupuestado;
                            pedidos[index].Horas_presupuestadas = cifAUX.numeroPedido;
                        }
                    }
                }
            }
        }
        public void cargarManos_de_Obra() 
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Mano de Obra.txt";


            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Boolean verif = false;
                    while (verif == false)
                    {
                        String line1 = sr.ReadLine();
                        String line2 = sr.ReadLine();


                        if (line1 == null)
                        {
                            verif = true;
                        }
                        else
                        {
                            String[] id_total = line1.Split('/');
                            String[] operarios = line2.Split('/');
                            List<Operario> manoOD = new List<Operario>();


                            for (int i = 0; i < operarios.Length - 1; i++)
                            {
                                String[] operarios_aux = operarios[i].Split('-');

                                Operario auxiliar = buscarOperario(operarios_aux[0]);

                                Operario op = new Operario(operarios_aux[0], auxiliar.id, auxiliar.tipo);

                                op.horasTrabajadas = int.Parse(operarios_aux[1]);
                                op.valorUnitario = double.Parse(operarios_aux[2]);
                                op.totalValue = double.Parse(operarios_aux[3]);
                                
                               manoOD.Add(op);

                            }
                            ManoDeObra MOD = new ManoDeObra(int.Parse(id_total[0]), manoOD);
                            MOD.totalValue = double.Parse(id_total[1]);
                            
                            manos_de_obra.Add(MOD);
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

        public void registrarManoObra(int numPed, List<Operario> operarios,double TotalMO)
        {
            ManoDeObra MO = new ManoDeObra(numPed,operarios);
            MO.totalValue = TotalMO;
            addDataMOD(MO);

        }

        public void addDataMOD(ManoDeObra manoDeObra)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Mano de Obra.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    String info = "";
                    for (int i = 0; i < manoDeObra.trabajadores.Count; i++)
                    {
                        TipoLabor aux = buscarTipoLabor(manoDeObra.trabajadores[i].tipo);
                        double total = aux.valuePerhour * manoDeObra.trabajadores[i].horasTrabajadas;
                        info += manoDeObra.trabajadores[i].name + "-" +
                            manoDeObra.trabajadores[i].horasTrabajadas + "-" + manoDeObra.trabajadores[i].valorUnitario +
                            "-" + manoDeObra.trabajadores[i].totalValue + "/";
                    }
                    sw.WriteLine(manoDeObra.numPedido + "/" + manoDeObra.totalValue);

                    sw.WriteLine(info);


                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    String info = "";
                    for (int i = 0; i < manoDeObra.trabajadores.Count; i++)
                    {
                        TipoLabor aux = buscarTipoLabor(manoDeObra.trabajadores[i].tipo);
                        double total = aux.valuePerhour * manoDeObra.trabajadores[i].horasTrabajadas;
                        info += manoDeObra.trabajadores[i].name + "-" +
                            manoDeObra.trabajadores[i].horasTrabajadas + "-" + manoDeObra.trabajadores[i].valorUnitario +
                            "-" + manoDeObra.trabajadores[i].totalValue + "/";
                    }
                    sw.WriteLine(manoDeObra.numPedido + "/" + manoDeObra.totalValue);

                    sw.WriteLine(info);

                }
            }
        }
        public void registrarOperario(String name, String id, String tipo)
        {
            Operario worker = new Operario(name,id,tipo);
            workers.Add(worker);
            addDataWorkers(worker);
        }

        public void addDataCIF(CIF cif)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\CIF.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(cif.numeroPedido + "/" + cif.cif_presupuestado + "/" + cif.horas_presupuestadas);
                }
            }else{
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(cif.numeroPedido + "/" + cif.cif_presupuestado + "/" + cif.horas_presupuestadas);
                }
            }
        }
        public void addDataPedido(Pedido ped)
        {
            string path = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\Pedidos.txt";
             string path2 = @"C:\Users\usuario\source\repos\Costs-s-project\Costos por órdenes de producción\Data\EstadoPedidos.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(ped.numeroPedido + "/" + ped.cantidad + "/" + ped.cliente + "/" + ped.articulo + "/" + ped.fechaCreacion.ToShortDateString());
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(ped.numeroPedido + "/" + ped.cantidad + "/" + ped.cliente + "/" + ped.articulo + "/" + ped.fechaCreacion.ToShortDateString());
                }
            }
            if (!File.Exists(path2))
            {
                using (StreamWriter sw = File.CreateText(path2))
                {
                    sw.WriteLine(ped.numeroPedido + "/" + ped.estado);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path2))
                {
                    sw.WriteLine(ped.numeroPedido + "/" + ped.estado);
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
                    }
                    sw.WriteLine(requisicion.numero_pedido + "/" + requisicion.totalRequisicion);

                    sw.WriteLine(info);
                    
               
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
                    sw.WriteLine(requisicion.numero_pedido + "/" + requisicion.totalRequisicion);
                    sw.WriteLine(info);

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
                    sw.WriteLine(operario.name + "/" + operario.id + "/" + operario.tipo);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(operario.name + "/" + operario.id + "/" + operario.tipo);
                }
            }
        }


    }
}
