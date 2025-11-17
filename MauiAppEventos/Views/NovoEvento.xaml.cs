using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class NovoEvento : ContentPage
{
    App PropriedadesApp;


    public NovoEvento()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_evento.ItemsSource = PropriedadesApp.lista_eventos;

        dtpck_DataInicio.MinimumDate = DateTime.Now;
        dtpck_DataInicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);

        dtpck_DataTermino.MinimumDate = dtpck_DataInicio.Date.AddDays(0);
        dtpck_DataTermino.MaximumDate = dtpck_DataInicio.Date.AddDays(4);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            EventoContratado h = new EventoContratado
            {
                EventoEscolhido = (Evento)pck_evento.SelectedItem,
                QntIngresso = Convert.ToInt32(stp_QntIngresso.Value),
                DataInicio = dtpck_DataInicio.Date,
                DataFinal = dtpck_DataTermino.Date,
            };

            await Navigation.PushAsync(new EventosAgendados()
            {
                BindingContext = h 
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Home());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_DataInicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_DataTermino.MinimumDate = data_selecionada_inicio.AddDays(0);
        dtpck_DataTermino.MaximumDate = data_selecionada_inicio.AddDays(4);
    }
}