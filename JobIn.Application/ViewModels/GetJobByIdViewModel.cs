using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.ViewModels
{
    public class GetJobByIdViewModel
    {
        public GetJobByIdViewModel(int id, string jobTitle, string jobDescription, double salary, string companyName, string cadidateName)
        {
            Id = id;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            Salary = salary;
            CompanyName = companyName;
            CandidateName = cadidateName;
        }

        public int Id { get; private set; }
        public string JobTitle { get; private set; }
        public string JobDescription { get; private set; }
        public double Salary { get; private set; }
        public string CompanyName { get; private set; }
        public string CandidateName { get; private set; }
    }
}
