namespace ProjectTracker.Core.Domain
{
    public class ProjectStage : BaseEntity<Guid, Guid>
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public bool SelectableInProjectStages { get; set; }
        public string? Description { get; set; }

        public virtual Project Project { get; set; }
    }
}
