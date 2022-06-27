using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Core.Entities
{
    public class UserCompetence : BaseEntity
    {
        public UserCompetence()
        {
        }

        public UserCompetence(int idUser, int idSkill, Competence competence)
        {
            IdUser = idUser;
            IdSkill = idSkill;
        }

        public int IdUser { get; private set; }
        public int IdSkill { get; private set; }
        public Competence Competence { get; private set; }
    }
}
