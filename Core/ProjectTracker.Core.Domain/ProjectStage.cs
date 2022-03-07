using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class ProjectStage : HasKeyBaseDomainObject
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public bool SelectableInProjectStages { get; set; }
        public string? Description { get; set; }

        public virtual Project Project { get; set; }
    }
}
