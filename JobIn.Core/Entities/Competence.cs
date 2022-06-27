using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Core.Entities
{
    public class Competence : BaseEntity
    {
        public Competence()
        {
        }

        public Competence(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
