using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {
            var email = EntryEmail.Text;
            var password = EntryPassword.Text;

            if (email == null)
            {
                ErrorLabel.Text = "Campo Email y/o contraseña no puede estar vacío";
            }
            else if (password == null)
            {
                ErrorLabel.Text = "Campo Email y/o contraseña no puede estar vacío";
            }
            else
            {
                MessageLogIn.Text = "Bienvenido " + email;
            }

        }

        private void RegisterPage_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegistrationPage();
        }
    }
}