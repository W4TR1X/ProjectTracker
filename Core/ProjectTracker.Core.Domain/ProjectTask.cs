namespace ProjectTracker.Core.Domain
{
    public class ProjectTask : BaseEntity<Guid, Guid>
    {
        public Guid ProjectId { get; set; }
        public Guid StageId { get; set; }
        public Guid? ParentTaskId { get; set; }
        public TaskRequestEnum TaskType { get; set; }
        public ProjectPiorityEnum Priority { get; set; }
        public Guid? OwnedUserId { get; set; }
        public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime TargetEndDate { get; set; }
        public TimeSpan TargetTime { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
        public bool IsLocket { get; set; }
        public bool IsArchived { get; set; }

        public virtual Project Project { get; set; }
        public virtual TaskStage TaskStage { get; set; }
        public virtual ProjectTask? ParentTask {get; set; }
        public virtual User? OwnedUser { get; set; }



    }
}
