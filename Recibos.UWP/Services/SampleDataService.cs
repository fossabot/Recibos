using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Recibos.UWP.Models;

namespace Recibos.UWP.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public static class SampleDataService
    {
        private static IEnumerable<ReciboModel> TodosRecibos()
        {
            // The following is order summary data
            var data = new ObservableCollection<ReciboModel>
            {
                new ReciboModel
                {
                    ReciboId = 1,
                    Data = new DateTime(2018, 05, 2),
                    TomadorNome = "Janeide Simões",
                    TomadorCpf = "12345678901",
                    Servico = "Declaração de Imposto de Renda",
                    Valor = Convert.ToDouble("100,00")
                },
                new ReciboModel
                {
                    ReciboId = 2,
                    Data = new DateTime(2018, 05, 5),
                    TomadorNome = "Adna Santana",
                    TomadorCpf = "23456789012",
                    Servico = "Escrita de contrato de locação",
                    Valor = Convert.ToDouble("20,00")
                },
                new ReciboModel
                {
                    ReciboId = 3,
                    Data = new DateTime(2018, 05, 10),
                    TomadorNome = "Rebeca Nunes",
                    TomadorCpf = "34567890123",
                    Servico = "Entrada de documentos na JUCEPE",
                    Valor = Convert.ToDouble("50,00")
                },
                new ReciboModel
                {
                    ReciboId = 4,
                    Data = new DateTime(2018, 05, 12),
                    TomadorNome = "Laura Cunha",
                    TomadorCpf = "45678901234",
                    Servico = "Declaração de Imposto de Renda",
                    Valor = Convert.ToDouble("100,00")
                },
                new ReciboModel
                {
                    ReciboId = 5,
                    Data = new DateTime(2018, 05, 15),
                    TomadorNome = "Pedro Siqueira",
                    TomadorCpf = "56789012345",
                    Servico = "Instalação de programas no PC",
                    Valor = Convert.ToDouble("80,00")
                },
                new ReciboModel
                {
                    ReciboId = 6,
                    Data = new DateTime(2018, 05, 16),
                    TomadorNome = "Carlos Nunes Jr.",
                    TomadorCpf = "67890123456",
                    Servico = "Abertura de empresa",
                    Valor = Convert.ToDouble("250,00")
                },
                new ReciboModel
                {
                    ReciboId = 7,
                    Data = new DateTime(2018, 05, 20),
                    TomadorNome = "Katia Maria",
                    TomadorCpf = "78901234567",
                    Servico = "Folha de pagamento de doméstica",
                    Valor = Convert.ToDouble("74,95")
                },
                new ReciboModel
                {
                    ReciboId = 8,
                    Data = new DateTime(2018, 05, 22),
                    TomadorNome = "Mônica Oliveira",
                    TomadorCpf = "89012345678",
                    Servico = "Arte de cartão de visitas",
                    Valor = Convert.ToDouble("25,00")
                },
                new ReciboModel
                {
                    ReciboId = 9,
                    Data = new DateTime(2018, 05, 25),
                    TomadorNome = "Guilherme Nascimento",
                    TomadorCpf = "90123456789",
                    Servico = "Declaração de Imposto de Renda",
                    Valor = Convert.ToDouble("100,00")
                },
                new ReciboModel
                {
                    ReciboId = 10,
                    Data = new DateTime(2018, 5, 30),
                    TomadorNome = "Gerlane Silva",
                    TomadorCpf = "01234567890",
                    Servico = "Gravação de CD/DVD",
                    Valor = Convert.ToDouble("10,00")
                },
            };

            return data;
        }

        // TODO WTS: Remove this once your grid page is displaying real data
        public static ObservableCollection<ReciboModel> GetGridSampleData()
        {
            return new ObservableCollection<ReciboModel>(TodosRecibos());
        }
    }
}
