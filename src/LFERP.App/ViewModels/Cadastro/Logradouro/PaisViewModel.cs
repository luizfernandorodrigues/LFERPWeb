using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LFERP.App.ViewModels.Cadastro.Logradouro
{
    public class PaisViewModel
    {
        #region Propriedades View

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }

        #endregion

        public IEnumerable<EstadoViewModel> Estados { get; set; }
    }
}
