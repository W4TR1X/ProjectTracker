namespace ProjectTracker.Core.Domain
{
    public class TaskActivityComment : BaseEntity<Guid, Guid>
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
