using JobIn.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.Services.Interfaces
{
    public interface ICompetenceService
    {
        Task<List<GetAllCompetencesViewModel>> GetAllCompetences();
    }
}
