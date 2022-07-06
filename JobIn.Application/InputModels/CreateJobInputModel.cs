using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.InputModels
{
    public class CreateJobInputModel
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int IdCompany { get; set; }
        public int IdCandidate { get; set; }
        public double Salary { get; set; }        
    }
}
