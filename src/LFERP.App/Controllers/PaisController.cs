using AutoMapper;
using LFERP.App.ViewModels.Cadastro.Logradouro;
using LFERP.Negocio.Interface.Cadastro.Logradouro;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LFERP.App.Controllers
{
    public class PaisController : Controller
    {
        private readonly IPaisRepositorio paisRepositorio;
        private readonly IMapper mapper;

        public PaisController(IPaisRepositorio paisRepositorio, IMapper mapper)
        {
            this.paisRepositorio = paisRepositorio;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(mapper.Map<IEnumerable<PaisViewModel>>(await paisRepositorio.ObterTodos()));
        }

        public async Task<IActionResult> Detalhes(Guid id)
        {
            var pais = mapper.Map<PaisViewModel>(await paisRepositorio.ObterPorId(id));

            if (pais == null)
                return NotFound();

            return View(pais);
        }
    }
}
