using JobIn.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobIn.API.Controllers
{
    [Route("api/competences")]
    public class CompetencesController : ControllerBase
    {
        private readonly ICompetenceService _service;
        public CompetencesController(ICompetenceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompetences()
        {
            var comp = await _service.GetAllCompetences();

            return Ok(comp);
        }
    }
}
