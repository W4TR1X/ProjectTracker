using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskStageConfiguration : IEntityTypeConfiguration<TaskStage>
    {
        public void Configure(EntityTypeBuilder<TaskStage> builder)
        {
            builder.ToTable("TaskStages");
           
            builder.Property(ts => ts.TaskId).IsRequired();    
        }
    }
}
