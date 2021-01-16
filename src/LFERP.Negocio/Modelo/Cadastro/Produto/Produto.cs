using System;

namespace LFERP.Negocio.Modelo.Cadastro.Produto
{
    /// <summary>
    /// Classe que representa um produto dentro da aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class Produto: Entidade
    {
        #region Propriedades

        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        #endregion
    }
}
