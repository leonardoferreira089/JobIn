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
            var getJob = await _context.Jobs.Include(getJob => getJob.Company)
                .Include(getJob => getJob.Candidate)
                .SingleOrDefaultAsync(j => j.Id == id);

            var getJobViewModel = new GetJobByIdViewModel(getJob.Id, getJob.JobTitle, getJob.JobDescription, getJob.Salary, getJob.Company.Name, getJob.Candidate.Name);

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

            _context.SaveChangesAsync();
        }

        public void CreateJobComment(CreateJobCommentInputModel inputModel)
        {
            var comment = new JobComment(inputModel.Content, inputModel.IdJob, inputModel.IdUser);

            _context.JobComments.Add(comment);

            _context.SaveChangesAsync();
        }

        public void Accepted(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            job.Accepted();

            _context.SaveChangesAsync();
        }

        public void InReviewMode(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            job.InReviewMode();

            _context.SaveChangesAsync();
        }

        public void NotApproved(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            job.NotApproved();

            _context.SaveChangesAsync();
        }

        public void RemoveJob(int id)
        {
            var job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            _context.Remove(job);

            _context.SaveChangesAsync();
        }
    }
}
