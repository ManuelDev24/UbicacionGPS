using Xamarin.Forms;

namespace UbicacionGPS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Código que se ejecuta cuando la aplicación se inicia
        }

        protected override void OnSleep()
        {
            // Código que se ejecuta cuando la aplicación entra en modo de suspensión
        }

        protected override void OnResume()
        {
            // Código que se ejecuta cuando la aplicación vuelve a estar activa
        }
    }
}
