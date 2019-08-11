using AnxietyNZ.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnxietyNZ.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text); 
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Oke");
            }
            else 
            {
                DisplayAlert("Login", "Login incorrect, empty username or password", "Oke");
            }
        }
    }
}