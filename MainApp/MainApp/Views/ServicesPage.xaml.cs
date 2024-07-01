using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MainApp.Views
{
    public partial class ServicesPage : ContentPage
    {
        private List<Service> _services;

        public ServicesPage()
        {
            InitializeComponent();

            _services = new List<Service>
            {
                new Service { Name = "Consultation", Description = "General Health Consultation" },
                new Service { Name = "Blood Test", Description = "Complete Blood Count" },
                new Service { Name = "X-Ray", Description = "Chest X-Ray" }
            };

            ServicesListView.ItemsSource = _services;
        }

        private async void OnAddServiceClicked(object sender, EventArgs e)
        {
            // Logic to add a service
        }

        private async void OnEditServiceClicked(object sender, EventArgs e)
        {
            if (ServicesListView.SelectedItem == null) return;
            // Logic to edit a service
        }

        private async void OnDeleteServiceClicked(object sender, EventArgs e)
        {
            if (ServicesListView.SelectedItem == null) return;
            // Logic to delete a service
        }
    }

    public class Service
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}