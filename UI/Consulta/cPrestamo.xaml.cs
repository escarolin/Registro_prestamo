using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Registro_prestamo.BLL;
using Registro_prestamo.Entidades;

namespace Registro_prestamo.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cPrestamo.xaml
    /// </summary>
    public partial class cPrestamo : Window
    {
        public cPrestamo()
        {
            InitializeComponent();
        }
 
      private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Datos.ItemsSource = null;
            var listado = new List<Prestamo>();

            if (DesdeDate.SelectedDate != null)
            {
                listado = PrestamoBLL.GetList(c => c.Fecha.Date >= HastaDate.SelectedDate);
            }
            else
            {
                listado = PrestamoBLL.GetList(c => true);
            }

            if (HastaDate.SelectedDate != null)
            {
                listado = PrestamoBLL.GetList(c => c.Fecha.Date <= HastaDate.SelectedDate);
            }
            else
            {
                listado = PrestamoBLL.GetList(c => true);
            }
            Datos.ItemsSource = listado;
        }

    }

}

