using CharlieDogs.DataAccess.Database.Entites;
using System.Data.Entity;

namespace CharlieDogs.DataAccess.Database
{
    public partial class DatabaseContext : DbContext
    {
        private static void ConfigureVendas(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendasEntity>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.Numero)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.Complemento)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.Bairro)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.Cep)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.NumeroCartao)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.Cvv)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.MesExpiracao)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.AnoExpiracao)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .Property(e => e.NomeCartao)
                        .IsUnicode(false);

            modelBuilder.Entity<VendasEntity>()
                        .HasMany(e => e.VendaCachorros)
                        .WithOptional(e => e.Venda)
                        .HasForeignKey(e => e.IdVenda);
        }
    }
}