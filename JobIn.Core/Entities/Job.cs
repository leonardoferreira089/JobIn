using JobIn.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Core.Entities
{
    public class Job : BaseEntity
    {
        public Job()
        {
        }

        public Job(string jobTitle, string jobDescription, int idCompany, int idCandidate, double salary)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            IdCompany = idCompany;
            IdCandidate = idCandidate;
            Salary = salary;
            CreatedAt = DateTime.Now;
            Status = StatusJob.Submitted;
            JobComments = new List<JobComment>();
        }

        public string JobTitle { get; private set; }
        public string JobDescription { get; private set; }
        public int IdCompany { get; private set; }
        public User Company { get; private set; }
        public int IdCandidate { get; private set; }
        public User Candidate { get; private set }
        public double Salary { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public StatusJob Status { get; private set; } = StatusJob.Submitted;
        public List<JobComment> JobComments { get; private set; }

        public void InReviewMode()
        {
            if(Status == StatusJob.Submitted)
            {
                Status = StatusJob.InReview;
            }
        }

        public void Accepted()
        {
            if(Status == StatusJob.InReview)
            {
                Status = StatusJob.Accepted;
            }
        }

        public void NotApproved()
        {
            if(Status == StatusJob.InReview)
            {
                Status = StatusJob.NotApproved;
            }
        }

        public void Update(string jobTitle, string jobDescription, double salary)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            Salary = salary;
        }
    }
}
