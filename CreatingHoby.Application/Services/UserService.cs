using CreatingHoby.Application.Dtos;
using CreatingHoby.Application.Interfaces;
using CreatingHoby.Domain.Entities;
using CreatingHoby.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Application.Services
{
        public class UserService : IUserService
        {
            private readonly List<User> _users;

            public UserService()
            {
                _users = new List<User>();
            }

            public UserDto GetUserById(Guid id)
            {
                var user = _users.FirstOrDefault(u => u.Id == id);
                return user = new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Role = user.Role.ToString()
                };
            }

            public IEnumerable<UserDto> GetAllUsers()
            {
                return _users.Select(user => new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Role = user.Role.ToString()
                }).ToList();
            }

            public void AddUser(UserDto userDto)
            {
                var user = new User
                {                    
                    Name = userDto.Name,
                    Email = userDto.Email,
                    Password = "hashed_password",
                    Role = (Role)Enum.Parse(typeof(Role), userDto.Role)
                };

                _users.Add(user);
            }

            public void UpdateUser(UserDto userDto)
            {
                var user = _users.FirstOrDefault(u => u.Id == userDto.Id);
                if (user != null)
                {
                    user.Name = userDto.Name;
                    user.Email = userDto.Email;
                    user.Role = (Role)Enum.Parse(typeof(Role), userDto.Role);
                }
            }

            public void DeleteUser(Guid id)
            {
                var user = _users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    _users.Remove(user);
                }
            }

        

       
    }
}
