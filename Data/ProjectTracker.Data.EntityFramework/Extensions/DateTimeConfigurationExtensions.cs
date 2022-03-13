namespace ProjectTracker.Data.EntityFramework.Extensions;

public static class DateTimeConfigurationExtensions
{

    public static void ConfigureDateTime(this PropertyBuilder<DateTime> builder)
    {
        builder.HasColumnType("datetime2(0)")
            .IsRequired();
    }
    public static void ConfigureDateTime(this PropertyBuilder<DateTime?> builder)
    {
        builder.HasColumnType("datetime2(0)");
    }

    public static void ConfigureDate(this PropertyBuilder<DateTime> builder)
    {
        builder.HasColumnType("date")
            .IsRequired();
    }
    public static void ConfigureDate(this PropertyBuilder<DateTime?> builder)
    {
        builder.HasColumnType("date");
    }

    public static void ConfigureTime(this PropertyBuilder<DateTime> builder)
    {
        builder.HasColumnType("time(0)")
            .IsRequired();
    }
    public static void ConfigureTime(this PropertyBuilder<DateTime?> builder)
    {
        builder.HasColumnType("time(0)");
    }
}