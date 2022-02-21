namespace ProjectTracker.Ui.Server.Common.Extensions;

public static class ReflectionExtensions
{
    public static List<T> GetInstanceFromTypeAssembly<T>(this Type t) where T : class
    {
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
        return t.Assembly.GetTypes()
        .Where(x => x.IsAssignableTo(typeof(T)) && !x.IsInterface && !x.IsAbstract)
        .Select(x => Activator.CreateInstance(x) as T)
        .Where(x => x != null) // null check yapılıyor
        .ToList();
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
    }
}
