var builder = WebApplication.CreateBuilder(args);

builder.RegisterServicesByRegistrars(typeof(Program));
builder.RegisterServicesByRegistrars(typeof(DefaultBuilderRegistrar));

var app = builder.Build();

app.SetupServicesByRegistrars(typeof(Program));
app.SetupServicesByRegistrars(typeof(DefaultApplicationRegistrar));

app.Run();