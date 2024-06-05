using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservacoesController : ControllerBase
    {
        private readonly IObservacoesRepositorio _observacoesRepositorio;

        public ObservacoesController(IObservacoesRepositorio observacoesRepositorio)
        {
            _observacoesRepositorio = observacoesRepositorio;
        }

        [HttpGet("GetAllObservacoes")]
        public async Task<ActionResult<List<ObservacoesModel>>> GetAllObservacoes()
        {
            List<ObservacoesModel> observacoes = await _observacoesRepositorio.GetAll();
            return Ok(observacoes);
        }


        [HttpGet("GetObservacoesId/{id}")]
        public async Task<ActionResult<ObservacoesModel>> GetObservacoeId(int id)
        {
            ObservacoesModel observacoes = await _observacoesRepositorio.GetById(id);
            return Ok(observacoes);
        }

        [HttpPost("InsertObservacoes")]
        public async Task<ActionResult<ObservacoesModel>> InsertObservacoe([FromBody] ObservacoesModel observacoeModel)
        {
            ObservacoesModel user = await _observacoesRepositorio.InsertObservacoes(observacoeModel);
            return Ok(user);
        }

        [HttpPut("UpdateObservacoes/{id:int}")]
        public async Task<ActionResult<ObservacoesModel>> UpdateObservacoes(int id, [FromBody] ObservacoesModel observacoeModel)
        {
            observacoeModel.ObservacoesId = id;
            ObservacoesModel observacoes = await _observacoesRepositorio.UpdateObservacoes(observacoeModel, id);
            return Ok(observacoes);
        }

        [HttpDelete("DeleteObservacoes/{id:int}")]
        public async Task<ActionResult<ObservacoesModel>> DeleteProduct(int id)
        {
            bool deleted = await _observacoesRepositorio.DeleteObservacoes(id);
            return Ok(deleted);
        }
    }
}
