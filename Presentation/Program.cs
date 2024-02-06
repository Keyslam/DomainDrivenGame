using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var hostBuilder = new HostBuilder()
	.UseServiceProviderFactory(new AutofacServiceProviderFactory())
	.UseSerilog((_, loggerConfiguration) => loggerConfiguration
		.WriteTo.Console()
	)
	.ConfigureContainer<ContainerBuilder>(builder =>
	{
		builder.RegisterModule(new CoreModule());
	});

var app = hostBuilder.Build();
var logger = app.Services.GetRequiredService<ILogger>();

app.Run();