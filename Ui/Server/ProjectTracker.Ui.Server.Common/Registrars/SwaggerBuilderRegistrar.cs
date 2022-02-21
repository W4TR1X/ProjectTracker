namespace ProjectTracker.Ui.Server.Common.Registrars
{
    public class SwaggerBuilderRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }
    }
}
