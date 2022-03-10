namespace ProjectTracker.Core.Domain
{
    public class TaskStage : BaseEntity<Guid, Guid>
    {
        public Guid TaskId { get; set; }
        public string Name { get; set; }    
        public string? Description { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }

    }
}
