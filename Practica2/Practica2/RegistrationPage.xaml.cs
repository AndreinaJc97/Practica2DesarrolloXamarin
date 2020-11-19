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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        void Register_Clicked(object sender, EventArgs e) 
        {
            var email = EntryEmail.Text;
            var password = EntryPassword.Text;
            var confirm_password = EntryUserConfirmPassword.Text;

            if ( email == null || password == null || confirm_password == null)
            {
                ErrorLabel.Text = "Los campos no pueden estar vacío";
            }
            else if ( password.Equals(confirm_password) == false)
            {
                ErrorLabel.Text = "contraseñas incorrectas";
            }
            else
            {
                App.Current.MainPage = new HomePage();
            }
        }

        private void GoBack_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }

    }
}