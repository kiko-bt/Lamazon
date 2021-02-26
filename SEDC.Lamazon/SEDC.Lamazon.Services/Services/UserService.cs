using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;

namespace SEDC.Lamazon.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public void Register(User registerModel)
        {
            throw new NotImplementedException();
        }

        public void LogIn(User logIn)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetCurrentUser(string username)
        {
            try
            {
                User user = _userRepository.GetByUsername(username);

                return new UserViewModel
                {
                    Id = user.Id,
                    Username = user.Username,
                    Fullname = string.Format("{0} {1}", user.FirstName, user.LastName)
                };
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
