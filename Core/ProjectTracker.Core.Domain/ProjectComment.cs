namespace ProjectTracker.Core.Domain
{
    public class ProjectComment : BaseEntity<Guid, Guid>
    {
        public Guid ProjectId { get; set; }
        public Guid? TaskId { get; set; }
        public Guid? ParentCommentId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; }

        public virtual Project Project { get; set; }
        public virtual  ProjectTask? ProjectTask { get; set; }
        public virtual ProjectComment? ParentComment { get; set; }
        public virtual EmojiEnum? EmojiEnum { get; set; }

    }
}
