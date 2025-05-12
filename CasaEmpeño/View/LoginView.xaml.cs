using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using CasaEmpeño.ViewModel;

namespace CasaEmpeño.View
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {

        public LoginView()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
            var vm = new LoginViewModel();
            vm.PropertyChanged += Vm_PropertyChanged;
            this.DataContext = vm;
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Vm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsViewVisible")
            {
                var vm = DataContext as LoginViewModel;
                if (vm != null && !vm.IsViewVisible)
                {
                    MainView main = new MainView();
                    main.Show();
                    this.Close();
                }
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btnCrearCuenta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

