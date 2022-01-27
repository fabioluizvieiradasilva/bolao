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
        private readonly IParticipantService participantService;

        public ParticipantController(IParticipantService participantService)
        {
            this.participantService = participantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetParticipants()
        {
            var participants = await this.participantService.GetParticipants();

            if (participants == null)
                return NoContent();

            return Ok(participants);
        }


    }
}
