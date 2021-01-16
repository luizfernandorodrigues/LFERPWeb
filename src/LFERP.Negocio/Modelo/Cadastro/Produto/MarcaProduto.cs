namespace LFERP.Negocio.Modelo.Cadastro.Produto
{
    /// <summary>
    /// Classe responsavel por representar uma marca de produto na aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class MarcaProduto : Entidade
    {
        #region Propriedades

        public string Codigo { get; set; }
        public string Nome { get; set; }

        #endregion
    }
}
