using Domain.Transferencia.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class TransferenciaContext : DbContext
    {
        public TransferenciaContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.;Database=TransferenciaNFC;Trusted_Connection=True;MultipleActiveResultSets=true",
                     b => b.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transferencia>(builder =>
            {
                builder.HasKey(x => x.Id);
                builder.Property(u => u.Id)
                       .HasDefaultValueSql("newid()");

                builder.Property(x => x.Nome)
                    .HasMaxLength(100);
                builder.Property(x => x.DispositivoId)
                    .IsRequired();
                builder.Property(x => x.Valor)
                    .IsRequired();
                builder.Property(x => x.Ativa)
                    .IsRequired();

                builder.HasIndex(x => new
                {
                    x.DispositivoId,
                    x.Ativa
                });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
