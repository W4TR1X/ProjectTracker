using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class ProjectHistory : HasKeyBaseDomainObject
    {
        public Guid ProjectId { get; set; }
        public Guid? TaskId { get; set; }
        public Guid OwnerUserId { get; set; }    
        public string Details { get; set; } 

        public virtual Project Project { get; set; }    
        public virtual ProjectTask? ProjectTask { get; set; }
        public virtual User OwnerUser { get; set; }

    }
}
