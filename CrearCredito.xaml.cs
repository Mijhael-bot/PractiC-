using PruebaTecnica.Model;
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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PruebaTecnica
{
    /// <summary>
    /// Lógica de interacción para CrearCredito.xaml
    /// </summary>
    public partial class CrearCredito : Window
    {
        public CrearCredito()
        {
            InitializeComponent();
        }

        private void Button_Guardar(object sender, RoutedEventArgs e)
        {
            var fcrea = (dateCreacion.SelectedDate.Value.Date).ToString("dd/MM/yyyy");
            var teaC = 0.12; //int.Parse(teaCreacon.Text);
            var cuot = int.Parse(NumCuotas.Text);

            decimal temt = (decimal)(Math.Abs((1 + teaC) * 1 / cuot) - 1);
            var credit = int.Parse(MontoCreacion.Text);

            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                var oCredito = new Model.Credito();

                oCredito.IdCredito = idCreditoGuard+1;
                oCredito.IdCliente = idClienteGuard;
                oCredito.montoCredito = credit;
                oCredito.nroCuotas = cuot;
                oCredito.TEA = teaC;
                oCredito.TEM = (double)temt;
                oCredito.FecCreacion = DateTime.Parse(fcrea);

                db.Credito.Add(oCredito);
                db.SaveChanges();
            }

            generarPago(fcrea, cuot, credit,(double)temt);
            //MessageBox.Show("Listo");

            MainWindow VentanaMain = new MainWindow();
            this.Close();
            VentanaMain.Show();

        }
        int idClienteGuard= 0;
        int idCreditoGuard = 0;
        int idPagoGuard = 0;
        private void Button_Buscar(object sender, RoutedEventArgs e)
        {
            var DNIB = BuscarDni.Text;

            

            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                //busqueda por dni
                var oCliente = db.Cliente.FirstOrDefault(p => p.DNI == DNIB);

                NombreBuscado.Text = oCliente.nombres;
                ApellidoBuscado.Text = oCliente.apellidos;
                idClienteGuard = oCliente.IdCliente;
            }

            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                //busqueda por maximo
                try
                {
                    idCreditoGuard = db.Credito.Max(p => p.IdCredito);
                }
                catch (Exception ex)
                {
                    idCreditoGuard = 0;
                }
                
                
            }

        }

        private void generarPago(string fecPago,int numCuotas,int credit, double temP)
        {
            //calculo de cuota
            double temC = temP * 0.01;
            decimal cuotaMensual = (decimal)(credit-(Math.Abs(credit * (temP * Math.Pow((temP + 1), numCuotas))) / Math.Abs(Math.Pow((1 + temP), numCuotas)) - 1));

          

            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                var oPago = new Model.Pago();

                for (int i = 0;i < numCuotas; i++)
                {
                    oPago.IdCliente = idClienteGuard;
                    oPago.IdCredito = idCreditoGuard+1;
                    //segun al numero de cuotas
                    oPago.nroCuota = i+1;
                    //monto mensual
                    oPago.montoCuota = (double)cuotaMensual;
                    oPago.FecPago = DateTime.Parse(fecPago);
                    oPago.interes = int.Parse(InteresesCrea.Text);

                    db.Pago.Add(oPago);
                    db.SaveChanges();
                }

                
            }
            
            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                //busqueda por maximo
                try
                {
                    idPagoGuard = db.Pago.Max(p => p.IdPago);
                }
                catch (Exception ex)
                {
                    idPagoGuard = 0;
                }


            }
            using (Model.PruebaTecEntities1 db = new Model.PruebaTecEntities1())
            {
                var oReporte= new Model.Reportes();

                for (int i = 0; i < numCuotas; i++)
                {
                    oReporte.IdCliente = idClienteGuard;
                    oReporte.IdCredito = idCreditoGuard;
                    oReporte.IdPago = idPagoGuard;
                    oReporte.CuotasC = i + 1;
                    oReporte.FechaP = DateTime.Parse(fecPago);
                    oReporte.CapitalC = (double)cuotaMensual;
                    oReporte.Intereses = int.Parse(InteresesCrea.Text);

                    db.Reportes.Add(oReporte);
                    db.SaveChanges();
                }


            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaMain = new MainWindow();
            this.Close();
            VentanaMain.Show();
        }
    }

    
    
}
