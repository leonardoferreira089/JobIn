using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Core.Entities
{
    public class JobComment : BaseEntity
    {
        public JobComment()
        {
        }

        public JobComment(string content, int idJob, int idUser)
        {
            Content = content;
            IdJob = idJob;
            IdUser = idUser;
            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }
        public int IdJob { get; private set; }
        public Job Job { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
        public DateTime CreatedAt { get; private set; }        
    }
}
