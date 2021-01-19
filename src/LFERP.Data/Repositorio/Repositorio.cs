using LFERP.Data.Contexto;
using LFERP.Negocio.Interface;
using LFERP.Negocio.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LFERP.Data.Repositorio
{
    /// <summary>
    /// Classe abstrata que implementa a interface IRepositorio da camada de negocio
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 18/01/2021
    /// </summary>
    public abstract class Repositorio<TEntidade> : IRepositorio<TEntidade> where TEntidade : Entidade, new()
    {
        #region Propriedades

        protected readonly ContextoBanco contextoBanco;
        protected readonly DbSet<TEntidade> DbSet;

        #endregion

        #region Construtor

        public Repositorio(ContextoBanco contexto)
        {
            contextoBanco = contexto;

            DbSet = contextoBanco.Set<TEntidade>();
        }

        #endregion

        #region Métodos Públicos

        public async Task<IEnumerable<TEntidade>> Buscar(Expression<Func<TEntidade, bool>> predicado)
        {
            return await DbSet.AsNoTracking().Where(predicado).ToListAsync();
        }

        public virtual async Task<TEntidade> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntidade>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(TEntidade entidade)
        {

            DbSet.Add(entidade);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntidade entidade)
        {

            DbSet.Update(entidade);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            var entidade = new TEntidade { Id = id };

            DbSet.Remove(entidade);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await contextoBanco.SaveChangesAsync();
        }

        public void Dispose()
        {
            contextoBanco?.Dispose();
        }

        #endregion

    }
}
