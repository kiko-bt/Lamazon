using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel, out bool isValid);
        void Logout();
        UserViewModel GetCurrentUser(string username);
    }
}