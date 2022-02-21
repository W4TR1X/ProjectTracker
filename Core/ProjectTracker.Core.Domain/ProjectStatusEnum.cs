namespace ProjectTracker.Core.Domain;

public enum ProjectStatusEnum
{
    Draft,
    PendingInitialApproval,
    InProgress,
    CompletedAwaitingApproval,
    Completed,
    Cancelled,
}
