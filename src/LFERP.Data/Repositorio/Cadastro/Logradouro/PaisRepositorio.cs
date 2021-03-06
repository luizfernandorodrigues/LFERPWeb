﻿using LFERP.Data.Contexto;
using LFERP.Negocio.Interface.Cadastro.Logradouro;
using LFERP.Negocio.Modelo.Cadastro.Logradouro;

namespace LFERP.Data.Repositorio.Cadastro.Logradouro
{
    /// <summary>
    /// Classe especializada do repositorio do objeto do Pais
    /// 
    /// Autor   : Luiz Fernando
    /// Data    : 18/01/2021
    /// </summary>
    public class PaisRepositorio : Repositorio<Pais>, IPaisRepositorio
    {
        public PaisRepositorio(ContextoBanco contexto) : base(contexto)
        {
        }
    }
}
