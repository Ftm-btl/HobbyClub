using CreatingHoby.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Application.Services
{
    public interface IClubService
    {
        ClubDto GetClubById(Guid id);
        IEnumerable<ClubDto> GetAllClubs();
        void AddClub(ClubDto clubDto);
        void UpdateClub(ClubDto clubDto);
        void DeleteClub(Guid id);
    }
}
