using LFERP.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LFERP.Negocio.Interface
{
    /// <summary>
    /// Interface do repositorio genérico do acesso a banco
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 18/01/2020
    /// </summary>
    public interface IRepositorio<TEntidade> : IDisposable where TEntidade : Entidade
    {
        Task Adicionar(TEntidade entidade);
        Task<TEntidade> ObterPorId(Guid id);
        Task<List<TEntidade>> ObterTodos();
        Task Atualizar(TEntidade entidade);
        Task Remover(Guid id);
        Task<IEnumerable<TEntidade>> Buscar(Expression<Func<TEntidade, bool>> predicado);
        Task<int> SaveChanges();
    }
}