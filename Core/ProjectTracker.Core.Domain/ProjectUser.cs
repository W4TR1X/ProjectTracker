using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class ProjectUser : HasKeyBaseDomainObject
    {
        public Guid ProjectId { get; set; }
        public bool TrackActions { get; set; }
        public Guid UserId { get; set; }
        public ProjectJoinTypeEnum JoinType { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }

    }
}
