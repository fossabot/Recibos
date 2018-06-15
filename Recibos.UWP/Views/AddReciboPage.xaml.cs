using Recibos.Model;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

namespace Recibos.UWP.Views
{
    public sealed partial class AdcReciboPage : Page, INotifyPropertyChanged
    {
        public AdcReciboPage()
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
            using (var db = new RecibosContext())
            {
                var recibo = new Recibo
                {
                    TomadorNome = TomadorNome.Text,
                    TomadorCpf = TomadorCpf.Text,
                    ServicoDescricao = ServicoDesc.Text,
                    ServicoValor = ServicoValor.Text,
                    ServicoData = ServicoData.Date.ToString()
                };
                db.Recibos.Add(recibo);
                await db.SaveChangesAsync();
            }

            // Pergunta ao usuário se deseja adicionar um novo recibo.
            ContentDialog dialog = new ContentDialog
            {
                Title = "Adicionar Recibo",
                Content = "Recibo adicionado.\n\nDeseja adicionar um novo recibo?",
                PrimaryButtonText = "Sim",
                SecondaryButtonText = "Não"
            };

            ContentDialogResult result = await dialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                // Retorna os campos para seus valores padrão
                TomadorNome.Text = "";
                TomadorCpf.Text = "";
                ServicoDesc.Text = "";
                ServicoValor.Text = "";
                ServicoData.Date = DateTime.Now;
            }
            else
            {
                // Volta para MainPage
                Frame.GoBack();
            }
        }

        private async void BtnCancelar_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Cancela a adição do recibo atual.
            ContentDialog dialog = new ContentDialog
            {
                Title = "Cancelar Recibo",
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
