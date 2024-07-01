using System;
using MainApp.Pages;
using Xamarin.Forms;

namespace MainApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // For simplicity, directly navigate to MainPage
            await Navigation.PushAsync(new MainPage());
        }
    }
}