using LFERP.Data.Contexto;
using LFERP.Negocio.Interface.Cadastro.Logradouro;
using LFERP.Negocio.Modelo.Cadastro.Logradouro;

namespace LFERP.Data.Repositorio.Cadastro.Logradouro
{
    /// <summary>
    /// Classe especializada do repositorio do objeto do Cep
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 18/01/2021
    /// </summary>
    public class CepRepositorio : Repositorio<Cep>, ICepRepositorio
    {
        public CepRepositorio(ContextoBanco contexto) : base(contexto)
        {
        }
    }
}
