using bolao.api.Entities;
using bolao.api.Model;
using bolao.api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ParticipantController : Controller
    {
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetParticipants()
        {
            var participants = await _participantService.GetParticipants();

            if (participants == null)
                return NoContent();

            return Ok(participants);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var participant = await _participantService.GetParticipantId(id);
            if (participant == null)
                return NoContent();

            return Ok(participant);
        }

        [HttpPost]
        public IActionResult SaveParticipant(AddParticipantInputModel model)
        {
            var participant = new Participant(
                model.Name,
                model.Photo,
                model.Surname
                );

            if (participant == null)
                return BadRequest();

           _participantService.AddParticipant(participant);

            return Ok(participant);            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpDateParticipant(int id, AddParticipantInputModel model)
        {            
            if (model == null)
                return NoContent();
            
            await _participantService.UpDateParticipant(id, model);

            return Ok();
        }


    }
}
