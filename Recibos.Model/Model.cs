using Microsoft.EntityFrameworkCore;
using System;

namespace Recibos.Model
{
    public class RecibosContext : DbContext
    {
        public DbSet<Recibo> Recibos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Recibos.db");
        }
    }

    public class Recibo
    {
        public int ReciboId { get; set; }
        public string TomadorNome { get; set; }
        public string TomadorCpf { get; set; }
        public string ServicoDescricao { get; set; }
        public string ServicoValor { get; set; }
        public string ServicoData { get; set; }
    }
}
