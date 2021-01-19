using LFERP.Negocio.Modelo.Cadastro.Logradouro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LFERP.Data.Mapeamento.Cadastro.Logradouro
{
    /// <summary>
    /// Classe responsavel por mapear o objeto Cidade no banco de dados
    /// 
    /// Autor   : Luiz FErnando
    /// Data    : 18/01/2021
    /// </summary>
    public class CidadeMapeamento : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidade", "Cadastro");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").HasColumnType("UNIQUEIDENTIFIER");

            builder.Property(c=>c.Nome).HasColumnName("Nome").HasColumnType("VARCHAR(MAX)").IsRequired(true);

            builder.HasMany(c => c.Ceps).WithOne(c => c.Cidade).HasForeignKey(c => c.IdCidade).HasConstraintName("FK_Cep_IdCidade").IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
