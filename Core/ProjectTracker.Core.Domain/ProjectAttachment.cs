using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class ProjectAttachment : HasKeyBaseDomainObject
    {
        public Guid ProjectId { get; set; }
        public Guid? TaskId { get; set; }
        public string AttachmentPath { get; set; }
        public string? DisplayText { get; set; }
        public string Description { get; set; }

        public virtual Project Project {get; set; }
        public virtual ProjectTask? ProjectTask {get; set;}

    }
}
