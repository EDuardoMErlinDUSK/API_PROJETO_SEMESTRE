using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoasRepositorio _pessoasRepositorio;

        public PessoasController(IPessoasRepositorio pessoasRepositorio)
        {
            _pessoasRepositorio = pessoasRepositorio;
        }

        [HttpGet("GetAllPessoas")]
        public async Task<ActionResult<List<PessoasModel>>> GetAllPessoas()
        {
            List<PessoasModel> pessoas = await _pessoasRepositorio.GetAll();
            return Ok(pessoas);
        }


        [HttpGet("GetPessoaId/{id}")]
        public async Task<ActionResult<PessoasModel>> GetPessoaId(int id)
        {
            PessoasModel pessoas = await _pessoasRepositorio.GetById(id);
            return Ok(pessoas);
        }

        [HttpPost("InsertPessoas")]
        public async Task<ActionResult<PessoasModel>> InsertPessoa([FromBody] PessoasModel pessoaModel)
        {
            PessoasModel user = await _pessoasRepositorio.InsertPessoa(pessoaModel);
            return Ok(user);
        }

        [HttpPut("UpdatePessoas/{id:int}")]
        public async Task<ActionResult<PessoasModel>> UpdatePessoas(int id, [FromBody] PessoasModel pessoaModel)
        {
            pessoaModel.PessoaId = id;
            PessoasModel pessoa = await _pessoasRepositorio.UpdatePessoa(pessoaModel, id);
            return Ok(pessoa);
        }

        [HttpDelete("DeletePessoas/{id:int}")]
        public async Task<ActionResult<PessoasModel>> DeleteProduct(int id)
        {
            bool deleted = await _pessoasRepositorio.DeletePessoa(id);
            return Ok(deleted);
        }
    }
}
