using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVD.Context.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DVD.API.Controllers
{
    [ApiController]
    [Route("Filmes")]
    public class FilmesController : ControllerBase
    {
        public FilmesController()
        {
        }

        [HttpGet]
        [Route("FilmesGet")]
        public ActionResult GetFilmes()
        {
            var result = new Filme()
            {
                Nome = "De volta para o futuro I"
            };
            return Ok(result);
        }
    }
}

