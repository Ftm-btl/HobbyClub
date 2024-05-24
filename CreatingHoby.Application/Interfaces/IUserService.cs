using CreatingHoby.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Application.Interfaces
{
    public interface IUserService
    {
        UserDto GetUserById(Guid id);
        IEnumerable<UserDto> GetAllUsers();
        void AddUser(UserDto userDto);
        void UpdateUser(UserDto userDto);
        void DeleteUser(Guid id);
    }
}
