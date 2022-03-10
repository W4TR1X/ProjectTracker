﻿namespace ProjectTracker.Core.Domain;

public class ProjectType : BaseEntity<Guid, Guid>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsDisabled { get; set; }    

}