using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IUserService
    {
        //TODO: Change all the User domain models with appropriate ViewModel!!!
        void Register(User registerModel);
        void LogIn(User logIn);
        void LogOut();
        UserViewModel GetCurrentUser(string username);
    }
}
