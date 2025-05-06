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

namespace CasaEmpeño.View
{
    /// <summary>
    /// Lógica de interacción para MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEmpeñar_Click(object sender, RoutedEventArgs e)
        {
            InformacionProductoView ventanaEmpeñar = new InformacionProductoView();
            ventanaEmpeñar.Show();
            this.Close();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            ProductosView ventanaProductos = new ProductosView();
            ventanaProductos.Show();
            this.Close();
        }
    }
}
