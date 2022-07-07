using JobIn.Application.InputModels;
using JobIn.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.Services.Interfaces
{
    public interface IJobService 
    {
        Task<List<GetAllJobsViewModel>> GetAllJobs();
        Task<GetJobByIdViewModel> GetJobById(int id);
        Task<int> CreateJob(CreateJobInputModel inputModel);        
        void UpdateJob(UpdateJobInputModel inputModel);
        void CreateJobComment(CreateJobCommentInputModel inputModel);
        void RemoveJob(int id);
        void InReviewMode(int id);
        void Accepted(int id);
        void NotApproved(int id);
    }
}
