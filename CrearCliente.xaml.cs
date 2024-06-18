using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace PruebaTecnica
{
    /// <summary>
    /// Lógica de interacción para CrearCliente.xaml
    /// </summary>
    public partial class CrearCliente : Window
    {
        
        public CrearCliente()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fnac = (dateNacimiento.SelectedDate.Value.Date).ToString("dd/MM/yyyy");
            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                var oCliente = new Model.Cliente();
                
                oCliente.nombres = txtNombres.Text;
                oCliente.apellidos = txtApellidos.Text;
                oCliente.DNI = txtDNI.Text;
                oCliente.fNacimiento = DateTime.Parse(fnac);

                db.Cliente.Add(oCliente);
                db.SaveChanges();
            }

            //MessageBox.Show("Listo" );

            MainWindow VentanaMain = new MainWindow();
            this.Close();
            VentanaMain.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaMain = new MainWindow();
            this.Close();
            VentanaMain.Show();
        }
    }
    
    
    
}
