using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void LogIn(LoginViewModel logIn);
        void LogOut();
        UserViewModel GetCurrentUser(string username);
    }
}
