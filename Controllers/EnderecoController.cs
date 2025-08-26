using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Data;
using MinhaAPI.Models;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly AppDbContext _contextDb;
       public EnderecoController(AppDbContext contextDb){
        
            _contextDb = contextDb;

        }

        [HttpPost("Create")]
        public async Task<IActionResult> EnderecoCreate([FromBody] Endereco endereco) {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           _contextDb.Enderecos.Add(endereco);
            await _contextDb.SaveChangesAsync();

            return Ok("Endereço criado com sucesso");

        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteEndereco(int id) {

            Endereco? endereco = await _contextDb.Enderecos.FindAsync(id);

            if (endereco == null) 
            {
                return NotFound("Endereço não encontrado");
            }

            _contextDb.Enderecos.Remove(endereco);
            await _contextDb.SaveChangesAsync();

            return Ok("Endereço deletado com sucesso");

        }



        

    }
}
