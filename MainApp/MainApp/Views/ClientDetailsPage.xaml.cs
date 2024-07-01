using MainApp.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MainApp.Views
{
    public partial class ClientDetailsPage : ContentPage
    {
        private Client _client;

        public ClientDetailsPage(Client client)
        {
            InitializeComponent();
            _client = client;

            OrdersListView.ItemsSource = new List<Order>
            {
                new Order { OrderDescription = "Order 1 for " + _client.Name },
                new Order { OrderDescription = "Order 2 for " + _client.Name }
            };
        }

        public class Order
        {
            public string OrderDescription { get; set; }
        }
    }
}