using MauiAppEventos.Models;
using MauiAppEventos.Views;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public List<Evento> lista_eventos = new()
        {
            new()
            {
                Nome = "Comic Com",
                Lugar = "São Paulo",
                ValorIngresso = 500.0,
            },

            new()
            {
                Nome = "Anime Friends",
                Lugar = "São Paulo",
                ValorIngresso = 100.0,
            },

            new()
            {
                Nome = "Anime ABC",
                Lugar = "São Caetano",
                ValorIngresso = 80.0,
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Home());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500;
            window.Height = 700;

            return window;
        }
    }
}
