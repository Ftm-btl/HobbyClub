using CreatingHoby.Application.Dtos;
using CreatingHoby.Application.Interfaces;
using CreatingHoby.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Application.Services
{
    public class UserService : IUserServices
    {
        private readonly IUserServices _userServices;

        public UserService(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public void AddUser(UserDto userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Role = userDto.Role
            };

            
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
