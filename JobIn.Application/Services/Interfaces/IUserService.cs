using JobIn.Application.InputModels;
using JobIn.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser(int id);
        Task<int> Create(CreateUserInputModel inputModel);
    }
}
