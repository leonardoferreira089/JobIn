using JobIn.Application.InputModels;
using JobIn.Application.Services.Interfaces;
using JobIn.Application.ViewModels;
using JobIn.Core.Entities;
using JobIn.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        public readonly JobInDbContext _context;
        public UserService(JobInDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateUser(CreateUserInputModel inputModel)
        {
            var user = new User(inputModel.Name, inputModel.Email, inputModel.BirthDate, inputModel.Password);

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<UserViewModel> GetUser(int id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == id);

            var userViewModel = new UserViewModel(user.Name, user.Email);

            return userViewModel;
        }
    }
}
