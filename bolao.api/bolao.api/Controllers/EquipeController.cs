using System;
using bolao.api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using bolao.api.Model;
using bolao.api.Entities;

namespace bolao.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _equipeService;

        public EquipeController(IEquipeService equipeService)
        {
            _equipeService = equipeService;
        }

        [HttpGet]
        public async Task<IActionResult>GetEquipes()
        {
            try
            {
                var equipes = await _equipeService.GetEquipe();
                if (equipes == null)
                    return NoContent();

                return Ok(equipes);

            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível retornar as equipes. Erro: {e.Message}");
            }
        }

        [HttpPost]
        public IActionResult SaveEquipe(AddEquipeInputModel model)
        {
            try
            {
                if (model == null)
                    return BadRequest();

                var equipe = new Equipe(
                    model.Nome,
                    model.Escudo
                    );

                _equipeService.AddEquipe(equipe);
                return Ok(equipe);

            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao salvar a equipe. Erro: {e.Message}");
            }
        }
    }
}
