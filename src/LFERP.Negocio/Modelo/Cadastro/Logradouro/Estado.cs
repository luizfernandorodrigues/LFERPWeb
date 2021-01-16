using System;
using System.Collections.Generic;

namespace LFERP.Negocio.Modelo.Cadastro.Logradouro
{
    /// <summary>
    /// Classe responsavel por representar um Estado dentro da aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class Estado : Entidade
    {
        #region Propriedades

        public string Nome { get; set; }
        public string Sigla { get; set; }

        #endregion

        #region Relacionamento EF Core

        public Guid IdPais { get; set; }
        public Pais Pais { get; set; }

        public virtual IEnumerable<Cidade> Cidades { get; set; }

        #endregion
    }
}
