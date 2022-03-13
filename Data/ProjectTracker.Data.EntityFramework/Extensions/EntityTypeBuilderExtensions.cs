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

    public static void ConfigureGuid(this PropertyBuilder<Guid> builder)
    {
        builder.HasColumnType("uniqueidentifier")
            .IsRequired();
    }
    public static void ConfigureGuid(this PropertyBuilder<Guid?> builder)
    {
        builder.HasColumnType("uniqueidentifier")
            .IsFixedLength(true);
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
        ConfigureGuid(builder);
    }
    public static void ConfigureUser(this PropertyBuilder<Guid?> builder)
    {
        ConfigureGuid(builder);
    }


    private static void ConfigureCreatableEntity<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(ICreatableEntity<Guid>)))
        {
            builder.Property(x => ((ICreatableEntity<Guid>)x).CreatedBy)
               .ConfigureGuid();

            builder.Property(x => ((ICreatableEntity<Guid>)x).CreatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired();
        }
    }

    private static void ConfigureUpdatableEntity<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(IUpdatableEntity<Guid>)))
        {
            builder.Property(x => ((IUpdatableEntity<Guid>)x).UpdatedBy)
                .ConfigureUser();

            builder.Property(x => ((IUpdatableEntity<Guid>)x).UpdatedAt)
                .HasColumnType("datetime2(0)");
        }
    }

    private static void ConfigureDeletableEntity<T>(EntityTypeBuilder<T> builder) where T : class
    {
        if (typeof(T).IsAssignableTo(typeof(IDeletableEntity<Guid>)))
        {
            builder.Property(x => ((IDeletableEntity<Guid>)x).DeletedBy)
                .ConfigureUser();

            builder.Property(x => ((IDeletableEntity<Guid>)x).DeletedAt)
                .HasColumnType("datetime2(0)");
        }
    }
}
