using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using SpreadsheetLight;

namespace PruebaTecnica
{
    /// <summary>
    /// Lógica de interacción para BuscarPago.xaml
    /// </summary>
    public partial class BuscarPago : Window
    {
        
        public BuscarPago()
        {
            InitializeComponent();
            
            
        }
        List<ReporteViewModel> Listadatos = new List<ReporteViewModel>();
        private void Greporte()
        {
            

            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {

                Listadatos = (from d in db.Reportes
                                select new ReporteViewModel
                                {
                                    cuotasP = d.CuotasC,
                                    fechaP = d.FechaP,
                                    capitalC = d.CapitalC,
                                    interesesP = ((d.Intereses)*(0.01)) * (d.CapitalC),
                                    montoCuota = d.CapitalC + (((d.Intereses) * (0.01)) * (d.CapitalC))

                                }).ToList();
              
            }
            
            Datos.ItemsSource = Listadatos;

          


        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "Reporte.xlsx";
            SLDocument oSlDocument = new SLDocument();
            DataTable table1 = new DataTable();
            DataTable table = new DataTable();

            table1.Columns.Add("DNI", typeof(string));
            table1.Columns.Add("Nombre", typeof(string));

            table1.Rows.Add(DNiBusqueda.Text);
            table1.Rows.Add(NombresYApe.Text);

            //col
            table.Columns.Add("Cuotas", typeof(int));
            table.Columns.Add("Fecha cuota", typeof(String));
            table.Columns.Add("Capital", typeof (Double));
            table.Columns.Add("Intereses", typeof(int));
            table.Columns.Add("Monto", typeof(int));

            //registros
            foreach (var item in Listadatos)
            {
                table.Rows.Add(item.cuotasP,item.fechaP,item.capitalC,item.interesesP,item.montoCuota);
            }
            
            

            oSlDocument.ImportDataTable(1, 1, table1, true);
            oSlDocument.ImportDataTable(3, 1, table, true);
            oSlDocument.SaveAs(pathFile);


            MessageBox.Show("Reporte Generado");
            MainWindow VentanaMain = new MainWindow();
            this.Close();
            VentanaMain.Show();
        }

        private void Button_Buscar(object sender, RoutedEventArgs e)
        {
            var DNIB = DNiBusqueda.Text;



            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                //busqueda por dni
                var oCliente = db.Cliente.FirstOrDefault(p => p.DNI == DNIB);

                NombresYApe.Text = oCliente.nombres + " " + oCliente.apellidos;
 
            }

           

            Greporte();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaMain = new MainWindow();
            this.Close();
            VentanaMain.Show();
        }
    }

    public class ClienteViewModel
    {
        public int IdCliente { get; set; }
        public string DNI { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime? fNacimiento { get; set; }

    }

    public class ReporteViewModel
    {
        public int cuotasP { get; set; }
        public DateTime? fechaP { get; set; }
        public double capitalC { get; set; }
        public double interesesP { get; set; }
        public double montoCuota {  get; set; }
        

    }


}
