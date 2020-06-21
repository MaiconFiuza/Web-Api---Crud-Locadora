using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locadora.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Locadora.Data;
using Microsoft.EntityFrameworkCore;

namespace Locadora.Controllers
{
    [ApiController]
    [Route("loca/filmes")]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Filme>>> Get([FromServices] DataContext context)
        {
            var filmes = await context.Filmes.ToListAsync();
            return filmes;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Filme>> Post([FromServices] DataContext context,
            [FromBody] Filme model)
        {
            if (ModelState.IsValid)
            {
                context.Filmes.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }

            }

        }
}
