using AlgaMoney.Application.DtoModels;
using AlgaMoney.Application.Interfaces;
using AlgaMoney.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgaMoney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public ActionResult<CategoriaModel> Listar()
        {
            _categoriaService.GetCategorias();
            return Ok();
        }
    }
}
