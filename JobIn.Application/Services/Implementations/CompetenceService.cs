using JobIn.Application.Services.Interfaces;
using JobIn.Application.ViewModels;
using JobIn.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.Services.Implementations
{
    public class CompetenceService : ICompetenceService
    {
        private readonly JobInDbContext _context;
        public CompetenceService(JobInDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllCompetencesViewModel>> GetAllCompetences()
        {
            var competences = _context.Competences;

            var competencesVM = await competences.Select(c => new GetAllCompetencesViewModel(c.Id, c.Description)).ToListAsync();

            return competencesVM;
        }
    }
}
