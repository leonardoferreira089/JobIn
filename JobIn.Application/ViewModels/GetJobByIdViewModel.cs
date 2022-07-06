using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.ViewModels
{
    public class GetJobByIdViewModel
    {
        public GetJobByIdViewModel(string jobTitle, string jobDescription, double salary)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            Salary = salary;
        }

        public string JobTitle { get; private set; }
        public string JobDescription { get; private set; }
        public double Salary { get; private set; }
    }
}
