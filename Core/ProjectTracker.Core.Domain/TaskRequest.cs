using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class TaskRequest : HasKeyBaseDomainObject
    {
        public Guid TaskId { get; set; }
        public Guid OwnedUserId { get; set; }
        public Guid TargetUserId { get; set; }
        public TaskRequestEnum JoinType { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool? IsSuccessfull { get; set; }

        public virtual ProjectTask ProjectTask { get; set; }
        public virtual ProjectUser OwnedUser { get; set; }
        public virtual ProjectUser TargetUser { get; set; }
    }
}
