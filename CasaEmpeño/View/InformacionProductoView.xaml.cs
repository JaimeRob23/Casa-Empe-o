using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CasaEmpeño.View {
    public partial class InformacionProductoView : Window {
        public InformacionProductoView()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Click(object sender, RoutedEventArgs e)
        {
            // Código para continuar
        }

        private void SubirFoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar foto del producto";
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                ProductoImagen.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                ProductoImagen.Visibility = Visibility.Visible;
            }
        }
    }
}
