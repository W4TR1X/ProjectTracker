using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectTracker.Data.EntityFramework;

namespace ProjectTracker.Ui.Server.Common.Registrars
{
    public class EFCoreRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var appConnectionString = builder.Configuration.GetConnectionString("AppDatabase");

            //builder.Services.AddDbContextFactory<AppDbContext>(options =>
            //{
            //    options.UseSqlServer(appConnectionString, optionAction =>
            //    {
            //        optionAction.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            //        optionAction.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
            //    });
            //});

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(appConnectionString, optionAction =>
                {
                    optionAction.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    optionAction.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
                });
            });
        }
    }
}
