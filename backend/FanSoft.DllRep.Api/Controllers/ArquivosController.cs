using FanSoft.DllRep.Api.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FanSoft.DllRep.Api.Controllers
{
    [Route("api/v1/arquivos")]
    public class ArquivosController : Controller
    {
        private readonly DLLRepositoryContext _ctx;
        public ArquivosController(DLLRepositoryContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterArquivo(int id)
        {
            var arquivo = await _ctx.Arquivos.FindAsync(id);
            return Ok($"Toma aí o {id}");
        }

        [HttpGet()]
        public async Task<IActionResult> ObterArquivos()
        {
            var arquivos = await _ctx.Arquivos.ToListAsync();
            return Ok(arquivos);
        }

        [HttpPost()]
        public async Task<IActionResult> Upload()
        {
            var files = Request.Form.Files;

            foreach (var file in files)
            {
                // to do save
            }

            return Ok();
        }

    }
}
