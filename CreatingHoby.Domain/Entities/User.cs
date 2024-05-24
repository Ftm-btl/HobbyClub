using CreatingHoby.Domain.Common;
using CreatingHoby.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Domain.Entities
{
    public class User : EntityBase<Guid>
    {       
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

    }
}
