using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, DateTime birthDate, string password)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Password = password;
            Available = true;
            Competences = new List<UserCompetence>();
            CompanyJobs = new List<Job>();
            CandidateJobs = new List<Job>();
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; private set; }
        public bool Available { get; private set; }
        public List<UserCompetence> Competences { get; private set; }
        public List<Job> CompanyJobs { get; private set; }
        public List<Job> CandidateJobs { get; private set; }
        public List<JobComment> Comments { get; private set; }
    }
}
