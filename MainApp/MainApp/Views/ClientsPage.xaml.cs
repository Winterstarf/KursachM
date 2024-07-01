using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MainApp.Views
{
    public partial class ClientsPage : ContentPage
    {
        private List<Client> _clients;

        public ClientsPage()
        {
            InitializeComponent();

            _clients = new List<Client>
            {
                new Client { Name = "John Doe", Details = "Regular Checkup" },
                new Client { Name = "Jane Smith", Details = "Blood Test" },
                new Client { Name = "Alice Johnson", Details = "X-Ray" }
            };

            ClientsListView.ItemsSource = _clients;
        }

        private async void OnAddClientClicked(object sender, EventArgs e)
        {
            // Logic to add a client
        }

        private async void OnEditClientClicked(object sender, EventArgs e)
        {
            if (ClientsListView.SelectedItem == null) return;
            // Logic to edit a client
        }

        private async void OnDeleteClientClicked(object sender, EventArgs e)
        {
            if (ClientsListView.SelectedItem == null) return;
            // Logic to delete a client
        }

        private async void OnViewOrdersClicked(object sender, EventArgs e)
        {
            if (ClientsListView.SelectedItem == null) return;
            // Navigate to ClientDetailsPage with selected client
            await Navigation.PushAsync(new ClientDetailsPage((Client)ClientsListView.SelectedItem));
        }
    }

    public class Client
    {
        public string Name { get; set; }
        public string Details { get; set; }
    }
}