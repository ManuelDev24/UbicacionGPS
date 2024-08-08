using Xamarin.Forms;
using Xamarin.Essentials;
using System;

namespace UbicacionGPS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLatitud.Text, out double lat))
            {
                await DisplayAlert("Error", "Por favor ingresa una latitud válida.", "OK");
                return;
            }

            if (!double.TryParse(txtLongitud.Text, out double lng))
            {
                await DisplayAlert("Error", "Por favor ingresa una longitud válida.", "OK");
                return;
            }

            // Abre Google Maps con la ubicación proporcionada
            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = txtNombreUbicacion.Text,
                NavigationMode = NavigationMode.None
            });
        }
    }
}
