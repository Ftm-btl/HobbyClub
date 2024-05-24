using CreatingHoby.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHoby.Domain.Entities
{
    public class Event : EntityBase<Guid>
    {
        public string Description { get; set; }
        public DateTime Date {  get; set; }
        public string Location { get; set; }

    }
}
