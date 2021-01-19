using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LFERP.App.ViewModels.Cadastro.Logradouro
{
    public class EstadoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Guid IdPais { get; set; }
        public PaisViewModel Pais { get; set; }
        public virtual IEnumerable<CidadeViewModel> Cidades { get; set; }
    }
}
