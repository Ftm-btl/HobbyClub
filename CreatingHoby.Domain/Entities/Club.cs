using CreatingHoby.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Domain.Entities
{
    public class Club : EntityBase<Guid>
    {       
        public string Description { get; set; }
        public string Category { get; set; }

    }
}
