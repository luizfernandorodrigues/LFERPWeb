using System;

namespace LFERP.Negocio.Modelo
{
    /// <summary>
    /// Classe responsavel por representar todos os modelos da aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public abstract class Entidade
    {
        #region Propriedades

        public Guid Id { get; set; }

        #endregion

        #region Construtor
        
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        #endregion

    }
}
