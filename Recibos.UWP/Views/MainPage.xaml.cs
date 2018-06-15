using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Recibos.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Recibos.UWP.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            using (var db = new RecibosContext())
            {
                TodosRecibos.ItemsSource = db.Recibos.ToList();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void AddRecibo_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Chama a página de adição de recibos
            this.Frame.Navigate(typeof(AdcReciboPage));
        }

        private void EdtRecibo_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Chama a página de edição de recibos
            this.Frame.Navigate(typeof(EdtReciboPage));
        }

        private async void DelRecibo_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Cancela a adição do recibo atual.
            ContentDialog dialog = new ContentDialog
            {
                Title = "Apagar Recibo",
                Content = "Se prosseguir, este recibo será apagado. Deseja continuar?",
                PrimaryButtonText = "Sim",
                SecondaryButtonText = "Não"
            };

            ContentDialogResult result = await dialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                // Apaga o recibo
            }
        }

        private async void PrnRecibo_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog
            {
                Title = "Imprimir Recibo",
                Content = "A implementar",
                CloseButtonText = "OK"
            };

            ContentDialogResult result = await dialog.ShowAsync();
        }

        private void Settings_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Chama a página de configurações
            this.Frame.Navigate(typeof(SettingsPage));
        }
    }
}
