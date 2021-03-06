﻿using System;

namespace LFERP.Negocio.Modelo.Cadastro.Logradouro
{
    /// <summary>
    /// Classe responsavel por representar um CEP dentro da aplicação
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 16/01/2021
    /// </summary>
    public class Cep : Entidade
    {
        #region Propriedades

        public string CodigoEnderecamentoPostal { get; set; }

        #endregion

        #region Relacionamento EF Core

        public Guid IdCidade { get; set; }
        public Cidade Cidade { get; set; }

        #endregion
    }
}
