using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Recibos.UWP.Models;
using Recibos.UWP.Services;

using Windows.UI.Xaml.Controls;

namespace Recibos.UWP.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public MainPage()
        {
            InitializeComponent();
        }

        public ObservableCollection<ReciboModel> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
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
