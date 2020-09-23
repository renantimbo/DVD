using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVD.Context.Models;
using DVD.Util;
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
        [Route("GetFilmes")]
        public ActionResult GetFilmes()
        {
            var result = new Filme()
            {
                Nome = "De volta para o futuro I"
            };
            return Ok(result);
        }

        public static List<Filme> listaFilme = new List<Filme>();

        [HttpPost]
        [Route("PostFilmes")]
        public ActionResult PostFilmes(Filme Filme)
        {
            listaFilme.Add(Filme);

            return Ok(listaFilme);
        }

        [HttpGet]
        [Route("BuscaFilmes")]
        public ActionResult GetFilmes(string Filme)
        {
            var result = listaFilme.Where(q => q.Nome.Contains(Filme)).ToList();

            if (result.Count == 0)
                return BadRequest(Message.NoSuccess);
            else
                return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteFilmes")]
        public ActionResult DeleteFilmes(string Filme)
        {
            var result = listaFilme.RemoveAll(q => q.Nome == Filme);

            if (result == 0)
                return BadRequest(Message.NoSuccess);
            else
                return Ok(Message.Success);
        }
    }
}

