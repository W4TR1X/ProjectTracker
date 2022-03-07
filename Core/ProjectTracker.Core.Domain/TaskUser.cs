using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class TaskUser : HasKeyBaseDomainObject
    {
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }
        public ProjectJoinTypeEnum ProjectJoinTypeEnum { get; set; }

        public virtual ProjectTask ProjectTask { get; set; }
        public virtual User User { get; set; }

    }
}
