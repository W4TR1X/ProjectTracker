using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class TaskActivityComment : HasKeyBaseDomainObject
    {
        public Guid ActivityId { get; set; }
        public Guid? ProjectCommentId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; }
        public EmojiEnum? EmojiId { get; set; }

        public virtual TaskActivity TaskActivity { get; set; }
        public virtual ProjectComment? ProjectComment { get; set; }  
        public virtual TaskUser TaskUser { get; set; }




    }
}
