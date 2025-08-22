using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAPI.Data;
using MinhaAPI.Models;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ClienteController(AppDbContext appDbContext) {
        
            _appDbContext = appDbContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {

            List<Cliente> clientes = await _appDbContext.Clientes
                .Include(cliente => cliente.Enderecos)
                .ToListAsync();
            return Ok(clientes);
        
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Cliente cliente) {

            if (!ModelState.IsValid) { 
              return BadRequest(ModelState);
            }

            _appDbContext.Clientes.Add(cliente);
            await _appDbContext.SaveChangesAsync();
            return Ok("Cliente criado com sucesso");
        }

    }
}
