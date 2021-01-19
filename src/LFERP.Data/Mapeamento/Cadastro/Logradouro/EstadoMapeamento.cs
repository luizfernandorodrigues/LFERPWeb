using LFERP.Negocio.Modelo.Cadastro.Logradouro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LFERP.Data.Mapeamento.Cadastro.Logradouro
{
    /// <summary>
    /// Classe responsavel por mapear o objeto Estado para a tabela no banco de dados
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 18/01/2021
    /// </summary>
    public class EstadoMapeamento : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado", "Cadastro");

            builder.HasKey(e => e.Id).HasName("PK_Estado");
            builder.Property(e => e.Id).HasColumnName("Id").HasColumnType("uniqueidentifier");

            builder.Property(e => e.Nome).HasColumnName("Nome").HasColumnType("VARCHAR(100)").IsRequired(true);
            builder.Property(e => e.Sigla).HasColumnName("Sigla").HasColumnType("VARCHAR(2)").IsRequired(true);

            builder.HasMany(e => e.Cidades).WithOne(c => c.Estado).HasForeignKey(c => c.IdEstado).HasConstraintName("FK_Cidade_IdEstado").IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
