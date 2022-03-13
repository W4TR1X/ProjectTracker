namespace ProjectTracker.Data.EntityFramework.Extensions;

public static class EntityTypeBuilderExtensions
{
    public static void Configure<T>(this EntityTypeBuilder<T> builder) where T : class
    {
        // Id
        ConfigureId(builder);

        // Create
        ConfigureCreatableEntity(builder);

        // Update
        ConfigureUpdatableEntity(builder);

        // Delete
        ConfigureDeletableEntity(builder);
    }

    private static void ConfigureId<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(IBaseEntity<Guid>)))
        {
            builder.HasKey(x => ((IBaseEntity<Guid>)x).Id);

            builder.Property(x => ((IBaseEntity<Guid>)x).Id)
                .ConfigureGuid();
        }
        else if (typeof(T).IsAssignableTo(typeof(IBaseEntity<int>)))
        {
            builder.HasKey(x => ((IBaseEntity<int>)x).Id);

            builder.Property(x => ((IBaseEntity<int>)x).Id)
                .IsRequired();
        }
    }


    public static void ConfigureUser(this PropertyBuilder<Guid> builder)
    {
        GuidConfigurationExtensions.ConfigureGuid(builder);
    }
    public static void ConfigureUser(this PropertyBuilder<Guid?> builder)
    {
        GuidConfigurationExtensions.ConfigureGuid(builder);
    }


    private static void ConfigureCreatableEntity<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(ICreatableEntity<Guid>)))
        {
            builder.Property(x => ((ICreatableEntity<Guid>)x).CreatedBy)
               .ConfigureUser();

            builder.Property(x => ((ICreatableEntity<Guid>)x).CreatedAt)
                .ConfigureDateTime();
        }
    }

    private static void ConfigureUpdatableEntity<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(IUpdatableEntity<Guid>)))
        {
            builder.Property(x => ((IUpdatableEntity<Guid>)x).UpdatedBy)
                .ConfigureUser();

            builder.Property(x => ((IUpdatableEntity<Guid>)x).UpdatedAt)
                .ConfigureDateTime();
        }
    }

    private static void ConfigureDeletableEntity<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(IDeletableEntity<Guid>)))
        {
            builder.Property(x => ((IDeletableEntity<Guid>)x).DeletedBy)
                .ConfigureUser();

            builder.Property(x => ((IDeletableEntity<Guid>)x).DeletedAt)
                .ConfigureDateTime();
        }
    }
}
