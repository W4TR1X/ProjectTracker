using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class TaskCheckList : HasKeyBaseDomainObject
    {
        public Guid TaskId { get; set; }
        public Guid OwnedUserId { get; set; }    
        public string Description { get; set; }
        public Guid CompletorUserId { get; set; }   

        public virtual TaskUser OwnedUser { get; set; }
        public virtual TaskUser CompleterUser { get; set; }
    }
}
