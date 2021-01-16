using System;

namespace LFERP.Negocio.Enumerador
{
    /// <summary>
    /// Enum que representa os tipos de parceiro de negocio que a aplicação suporta
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    [Flags]
    public enum ETipoParceiroNegocio
    {
        Cliente = 1,
        Fornecedor = 2,
        Funcionario = 4,
        Transportadora = 8
    }
}
