using FanSoft.DllRep.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FanSoft.DllRep.Api.Core.Data
{
    public class DLLRepositoryContext : DbContext
    {

        public DLLRepositoryContext(DbContextOptions<DLLRepositoryContext> options) : base(options)
        {
            this.Initialize();

        }

        public DLLRepositoryContext()
        {
        }

        public DbSet<Arquivo> Arquivos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arquivo>(entity =>
            {

                entity.ToTable(nameof(Arquivo));
                entity.HasKey(col => col.Id);

                entity.Property(col => col.Id)
                        .HasColumnName(nameof(Arquivo.Id)).HasColumnType("int")
                        .ValueGeneratedOnAdd();

                entity.Property(col => col.Nome)
                    .HasColumnName(nameof(Arquivo.Nome)).HasColumnType("varchar(255)")
                    .IsRequired();

                entity.Property(col => col.Descricao)
                    .HasColumnName(nameof(Arquivo.Descricao)).HasColumnType("varchar(255)");


                entity.Property(col => col.Conteudo)
                    .HasColumnName(nameof(Arquivo.Conteudo)).HasColumnType("varbinary(max)")
                    .IsRequired();

            });




        }
    }
}
