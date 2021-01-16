using LFERP.Negocio.Modelo.Cadastro.Logradouro;
using Microsoft.EntityFrameworkCore;

namespace LFERP.Data.Contexto
{
    /// <summary>
    /// Classe responsável pelo contexto de acesso a dados da aplicação Herda de DbContext
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2020
    /// </summary>
    public class ContextoBanco : DbContext
    {
        #region Construtor

        public ContextoBanco(DbContextOptions options) : base(options) { }

        #endregion

        #region DbSet

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
      //  public DbSet<Cidade> Cidades { get; set; }
      //  public DbSet<Cep> Ceps { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextoBanco).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
