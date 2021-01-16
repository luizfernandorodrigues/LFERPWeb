

using System.Collections.Generic;

namespace LFERP.Negocio.Modelo.Cadastro.Logradouro
{
    /// <summary>
    /// Classe modelo que representa um Pais na aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class Pais : Entidade
    {
        #region Propriedades

        public string Nome { get; set; }
        public string Codigo { get; set; }

        #endregion

        #region Relacionamento EF Core

        public virtual IEnumerable<Estado> Estados { get; set; }

        #endregion
    }
}
