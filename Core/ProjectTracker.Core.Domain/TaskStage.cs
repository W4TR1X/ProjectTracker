using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class TaskStage : HasKeyBaseDomainObject
    {
        public Guid TaskId { get; set; }
        public string Name { get; set; }    
        public string? Description { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }

    }
}
