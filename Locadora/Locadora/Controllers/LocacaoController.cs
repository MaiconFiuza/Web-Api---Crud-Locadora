using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Locadora.Data;
using Locadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Locadora.Controllers
{
    [ApiController]
    [Route("loca/locacoes")]
    public class LocacaoController : ControllerBase
    {
        

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Locacao>>> Get([FromServices] DataContext context)
        {
            var locacoes = await context.Locacoes.ToListAsync();
            return locacoes;
        }

        
    }
}
