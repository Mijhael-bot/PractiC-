using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaTecnica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CrearCliente_Click(object sender, RoutedEventArgs e)
        {
            CrearCliente ventanaCliente = new CrearCliente();
            this.Close();
            ventanaCliente.Show();
        }

        private void CrearCredito_Click(object sender, RoutedEventArgs e)
        {
            CrearCredito ventanaCredito = new CrearCredito();
            this.Close();
            ventanaCredito.Show();
        }

        private void BuscarPagos_Click(object sender, RoutedEventArgs e)
        {
            BuscarPago ventanaPago = new BuscarPago();
            this.Close();
            ventanaPago.Show();
        }
    }
}
