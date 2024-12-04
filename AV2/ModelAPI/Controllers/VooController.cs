using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelAPI.Context;
using ModelAPI.Entities;

namespace ModelAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class VooController : ControllerBase
    {
        private readonly AeroportoContext _context;
        public VooController( AeroportoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Voo voo)
        {
            _context.Add(voo);
            _context.SaveChanges();
            return Ok(voo);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var voo = _context.Voo.Find(id);

            if(voo == null)
                return NotFound();
            return Ok(voo);
        }

        [HttpPut]
        public IActionResult Atualizar(int id, Voo voo)
        {
            var vooBanco = _context.Voo.Find(id);

            if(vooBanco == null)
                return NotFound();

            vooBanco.Origem =  voo.Origem;
            vooBanco.Destino =  voo.Destino;

            _context.Voo.Update(vooBanco);
            _context.SaveChanges();

            return Ok(vooBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var vooBanco = _context.Voo.Find(id);

            if(vooBanco == null)
                return NotFound();

            _context.Voo.Update(vooBanco);
            _context.SaveChanges();

            return NoContent();
        }


    }
}