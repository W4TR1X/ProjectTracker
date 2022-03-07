using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class TaskActivity : HasKeyBaseDomainObject
    {
        public Guid TaskId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan TotalTime { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }

        public virtual ProjectTask ProjectTask { get; set; }
        public virtual ProjectUser OwnedUser { get; set; }

    }
}
