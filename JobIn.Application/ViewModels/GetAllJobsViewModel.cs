using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.ViewModels
{
    public class GetAllJobsViewModel
    {
        public GetAllJobsViewModel(int id, string jobTitle, DateTime createdAt)
        {
            Id = id;
            JobTitle = jobTitle;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string JobTitle { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
