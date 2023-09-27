using ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

namespace ServiceLifetimeWebApplication.DependencyInjectionSample;

internal sealed class ExampleSingletonService : IExampleSingletonService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}