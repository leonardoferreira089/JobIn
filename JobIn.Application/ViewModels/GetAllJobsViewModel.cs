using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.ViewModels
{
    public class GetAllJobsViewModel
    {
        public GetAllJobsViewModel(string jobTitle, DateTime createdAt)
        {
            JobTitle = jobTitle;
            CreatedAt = createdAt;
        }

        public string JobTitle { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
