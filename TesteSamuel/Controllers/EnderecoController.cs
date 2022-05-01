using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TesteSamuel.Data;
using TesteSamuel.Models;

namespace TesteSamuel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private EnderecoContext _context;

        public EnderecoController(EnderecoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult CriarEndereco([FromBody] Endereco endereco)
        {
            try
            {
                _context.Add(endereco);
                _context.SaveChanges();
                return Ok(endereco);
            }
            catch (System.Exception)
            {
                return BadRequest("Nao foi possivel adicionar este endereço");
            }
        }

        [HttpGet]
        public ActionResult ConsultarTodos()
        {
            try
            {
                return Ok(_context.Endereco);
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {

            try
            {
                var endereco = _context.Endereco.FirstOrDefault(x => x.Id == id);

                if (endereco == null)
                {
                    return NotFound();
                }

                return Ok(endereco);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeletarEndereco(int id)
        {
            try
            {
                var endereco = _context.Endereco.FirstOrDefault(x => x.Id == id);

                if (endereco == null)
                {
                    return NotFound();
                }

                _context.Remove(endereco);
                _context.SaveChanges();

                return Ok();
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEndereco(int id, [FromBody] Endereco endereco)
        {
            try
            {
                var end = _context.Endereco.FirstOrDefault(x => x.Id == id);

                if (end == null)
                {
                    return NotFound();
                }


                end.Cep = endereco.Cep;
                end.Rua = endereco.Rua;

                _context.Update(end);
                _context.SaveChanges();

                return Ok();
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
        }

    }
}
