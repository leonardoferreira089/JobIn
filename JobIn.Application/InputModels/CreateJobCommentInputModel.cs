using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.InputModels
{
    public class CreateJobCommentInputModel
    {
        public string Content { get; set; }
        public int IdJob { get; set; }
        public int IdUser { get; set; }

    }
}
