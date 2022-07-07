using JobIn.Application.InputModels;
using JobIn.Application.Services.Interfaces;
using JobIn.Application.ViewModels;
using JobIn.Core.Entities;
using JobIn.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.Services.Implementations
{
    public class JobService : IJobService
    {
        private readonly JobInDbContext _context;
        public JobService(JobInDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllJobsViewModel>> GetAllJobs()
        {
            var getAllJobs = _context.Jobs;

            var getAllViewModel = await getAllJobs.Select(j => new GetAllJobsViewModel(j.Id, j.JobTitle, j.CreatedAt)).ToListAsync();

            return getAllViewModel;
        }

        public async Task<GetJobByIdViewModel> GetJobById(int id)
        {
            var getJob = await _context.Jobs.SingleOrDefaultAsync(j => j.Id == id);

            var getJobViewModel = new GetJobByIdViewModel(getJob.Id, getJob.JobTitle, getJob.JobDescription, getJob.Salary);

            return getJobViewModel;
        }

        public async Task<int> CreateJob(CreateJobInputModel inputModel)
        {
            var job = new Job(inputModel.JobTitle, 
                inputModel.JobDescription, 
                inputModel.IdCompany, 
                inputModel.IdCandidate, 
                inputModel.Salary);

            await _context.AddAsync(job);
            await _context.SaveChangesAsync();

            return job.Id;
        }

        public void UpdateJob(UpdateJobInputModel inputModel)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == inputModel.Id);
            job.Update(job.JobTitle, job.JobDescription, job.Salary);
        }

        public void CreateJobComment(CreateJobCommentInputModel inputModel)
        {
            var comment = new JobComment(inputModel.Content, inputModel.IdJob, inputModel.IdUser);

            _context.JobComments.Add(comment);
        }

        public void Accepted(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            job.Accepted();
        }

        public void InReviewMode(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            job.InReviewMode();
        }

        public void NotApproved(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            job.NotApproved();
        }

        public void RemoveJob(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            _context.Remove(job);
        }
    }
}
