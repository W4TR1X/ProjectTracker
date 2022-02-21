namespace ProjectTracker.Ui.Server.Common.Registrars
{
    public class DefaultApplicationRegistrar : IWebApplicationRegistrar
    {
        public void SetupServices(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
