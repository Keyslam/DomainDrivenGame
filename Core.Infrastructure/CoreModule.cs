using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;

namespace Core.Infrastructure;

public class CoreModule() : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		var mediatrConfiguration = MediatRConfigurationBuilder
			.Create(typeof(Application.AssemblyInfo).Assembly)
			.WithAllOpenGenericHandlerTypesRegistered()
			.Build();

		builder.RegisterMediatR(mediatrConfiguration);
	}
}