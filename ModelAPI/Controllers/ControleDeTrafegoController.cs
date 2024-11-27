using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModelAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControleDeTrafegoController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"{nome}";
            return Ok(new {mensagem});
        }
    }
}