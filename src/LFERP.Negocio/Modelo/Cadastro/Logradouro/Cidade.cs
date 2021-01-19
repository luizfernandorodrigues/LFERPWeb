using System;
using System.Collections.Generic;

namespace LFERP.Negocio.Modelo.Cadastro.Logradouro
{
    /// <summary>
    /// Classe responsavel por representar uma cidade dentro da aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class Cidade : Entidade
    {
        #region Propriedades

        public string Nome { get; set; }

        #endregion

        #region Relacionamento EF Core

        public Guid IdEstado { get; set; }
        public Estado Estado { get; set; }
        public virtual IEnumerable<Cep> Ceps { get; set; }

        #endregion 
    }
}
