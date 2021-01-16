using LFERP.Negocio.Modelo.Cadastro.Logradouro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LFERP.Data.Mapeamento.Cadastro.Logradouro
{
    /// <summary>
    /// Classe responsavel por mapear o objeto Pais para a tabela no banco de dados
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class PaisMapeamento : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais", "Cadastro");

            builder.HasKey(p => p.Id).HasName("PK_Pais");
            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("uniqueidentifier");

            builder.Property(p => p.Codigo).HasColumnName("Codigo").HasColumnType("VARCHAR(20)").IsRequired(false);
            builder.Property(p => p.Nome).HasColumnName("Nome").HasColumnType("VARCHAR(100)").IsRequired(true);

            builder.HasMany(p => p.Estados).WithOne(e => e.Pais).HasForeignKey(e => e.IdPais).HasConstraintName("FK_Estado_IdPais").IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
