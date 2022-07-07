using JobIn.Application.InputModels;
using JobIn.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobIn.API.Controllers
{
    [Route("api/jobs")]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _service;
        public JobsController(IJobService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _service.GetAllJobs();            

            return Ok(jobs);
        }

        [HttpGet]
        public async Task<IActionResult> GetJobById(int id)
        {
            var job = await _service.GetJobById(id);

            return Ok(job);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJob(CreateJobInputModel inputModel)
        {
            if(inputModel.JobTitle.Length > 60)
            {
                return BadRequest();
            }

            var jobId = await _service.CreateJob(inputModel);

            return CreatedAtAction(nameof(GetJobById), new { jobId }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJob(int id, [FromBody] UpdateJobInputModel inputModel)
        {
            if (inputModel.JobTitle.Length > 60)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult CreateJobComment(int id, [FromBody] CreateJobCommentInputModel inputModel)
        {
            _service.CreateJobComment(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}/delete")]
        public IActionResult DeleteJob(int id)
        {
            _service.RemoveJob(id);

            return RedirectToAction(nameof(GetAllJobs));
        }

        [HttpPut("{id}/in-review")]
        public IActionResult InReview(int id)
        {
            _service.InReviewMode(id);

            return NoContent();
        }

        [HttpPut("{id}/accepted")]
        public IActionResult Accepted(int id)
        {
            _service.Accepted(id);

            return NoContent();
        }

        [HttpPut("{id}/not-approved")]
        public IActionResult NotApproved(int id)
        {
            _service.NotApproved(id);

            return NoContent();
        }

        //acho que terminei verificar o mindmap para ver inserir o serviço na startup
    }
}
