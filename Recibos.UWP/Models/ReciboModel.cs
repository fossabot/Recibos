using System;

namespace Recibos.UWP.Models
{
    // TODO WTS: Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and Master Detail.
    public class ReciboModel
    {
        public long ReciboId { get; set; }
        public DateTime Data { get; set; }
        public string TomadorNome { get; set; }
        public string TomadorCpf { get; set; }
        public string Servico { get; set; }
        public double Valor { get; set; }
    }
}
