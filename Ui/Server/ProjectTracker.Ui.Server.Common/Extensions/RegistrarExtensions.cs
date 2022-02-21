namespace ProjectTracker.Ui.Server.Common.Extensions;

public static class RegistrarExtensions
{
    public static WebApplicationBuilder RegisterServicesByRegistrars(this WebApplicationBuilder builder, Type scanningAssemblyType)
    {
        var registrars = scanningAssemblyType.GetInstanceFromTypeAssembly<IWebApplicationBuilderRegistrar>();

        registrars.ForEach(x => x.RegisterServices(builder));

        return builder;
    }

    public static WebApplication SetupServicesByRegistrars(this WebApplication app, Type scanningAssemblyType)
    {
        var registrars = scanningAssemblyType.GetInstanceFromTypeAssembly<IWebApplicationRegistrar>();

        registrars.ForEach(x => x.SetupServices(app));

        return app;
    }
}
