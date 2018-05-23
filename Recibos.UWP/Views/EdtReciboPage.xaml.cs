using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

namespace Recibos.UWP.Views
{
    public sealed partial class EdtReciboPage : Page, INotifyPropertyChanged
    {
        public EdtReciboPage()
        {
            InitializeComponent();
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

        private async void BtnSalvar_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Salva os dados do recibo no banco.

            // Avisa ao usuário que o recibo editao foi salvo.
            ContentDialog dialog = new ContentDialog
            {
                Title = "Editar Recibo",
                Content = "O recibo foi editado e salvo.",
                CloseButtonText = "OK"
            };

            ContentDialogResult result = await dialog.ShowAsync();
                        
                // Volta para MainPage
                Frame.GoBack();
        }

        private async void BtnCancelar_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Cancela a adição do recibo atual.
            ContentDialog dialog = new ContentDialog
            {
                Title = "Cancelar Editar Recibo",
                Content = "Se prosseguir, os dados serão apagados. Deseja continuar?",
                PrimaryButtonText = "Sim",
                SecondaryButtonText = "Não"
            };

            ContentDialogResult result = await dialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                // Volta para MainPage
                Frame.GoBack();
            }
        }
    }
}
