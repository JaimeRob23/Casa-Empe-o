using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
<<<<<<< HEAD
=======
using System.Security.Cryptography;
using System.Security.Principal;
>>>>>>> 7a177d5e2111b94b28dc134455f1ceb19e8361e7
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows;
using CasaEmpeño.Helpers;
using CasaEmpeño.View;
using System.ComponentModel;
using CasaEmpeño.Repositories;
<<<<<<< HEAD
using System.Runtime.CompilerServices;
using CasaEmpeño.Model;
using System.Net;
using System.Security.Principal;
using System.Threading;
=======
using CasaEmpeño.View;
>>>>>>> 7a177d5e2111b94b28dc134455f1ceb19e8361e7

namespace CasaEmpeño.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        // Campos
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
<<<<<<< HEAD
        private IUserRepository userRepository;

        // Propiedades. Lo que el get y el set van a hacer
=======
        private UserRepository userRepository;

        // Commands
        public ICommand LoginCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        // Propiedades
>>>>>>> 7a177d5e2111b94b28dc134455f1ceb19e8361e7
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        // Lo mismo para el error message y ese show
        public SecureString Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

<<<<<<< HEAD
        // Comandos. Para que nos deje entrar, que muestre la contraseña o cosas asi
        public ICommand LoginCommand { get; }
        public ICommand ShowPasswordCommand { get; }

        // Realizamos el constructor
=======
        // Constructor
>>>>>>> 7a177d5e2111b94b28dc134455f1ceb19e8361e7
        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username)
                || Username.Length < 3
                || Password == null
                || Password.Length < 3)
                validData = false;
            else
                validData = true;


            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = userRepository.AuthenticateUser(
                new NetworkCredential(Username, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(Username), null);
<<<<<<< HEAD
                IsViewVisible = false;

=======
                var ventanaPrincipal = new View.MainView();
                ventanaPrincipal.Show();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window is View.LoginView)
                        {
                            window.Close();
                            break;
                        }
                    }
                });
>>>>>>> 7a177d5e2111b94b28dc134455f1ceb19e8361e7
            }
            else
            {
                ErrorMessage = "* Invalid username or password";
            }
        }
    }
<<<<<<< HEAD

}
=======
}
>>>>>>> 7a177d5e2111b94b28dc134455f1ceb19e8361e7
